using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практична_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }

        private DBRequest UserReq;

        private DataTable RequestTab;

        private DataTable StructTab;
        private string LastTabName;

        private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserReq = new DBRequest();
 
            StructTab = new DataTable("TabFields");
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            datGridDBTables.DataSource = StructTab;
            
            datGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab;

            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged);

            int ColTablesWidth = datGridDBTables.Columns.GetColumnsWidth(0);
            datGridDBTables.Columns[1].Width = datGridDBTables.Width - ColTablesWidth - 37;

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            bool Connected = false;

            try
            {
                UserReq.Disconnect();
                UserReq.ConnectTo(tbDatSource.Text, tbInitCat.Text);
                Connected = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Connected = false;
            }
            
            if (Connected)
            {
                tbRequest.Enabled = true;
                btnRequest.Enabled = true;
                datGridSQLResult.Enabled = true;
                datGridDBTables.Enabled = true;
            }
            else
            {
                tbRequest.Enabled = false;
                btnRequest.Enabled = false;
                datGridSQLResult.Enabled = false;
                datGridDBTables.Enabled = false;
            }

            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            {
            }
        }


        private void BtnRequest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RequestTab = UserReq.SQLRequest(tbRequest.Text);
                datGridSQLResult.DataSource = RequestTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Request Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }

}
}
