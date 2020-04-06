using System.Data;

namespace Практична_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.datGridDBTables = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataSource";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Catalog";
            // 
            // tbDatSource
            // 
            this.tbDatSource.ForeColor = System.Drawing.Color.Green;
            this.tbDatSource.Location = new System.Drawing.Point(226, 33);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(425, 22);
            this.tbDatSource.TabIndex = 2;
            // 
            // tbInitCat
            // 
            this.tbInitCat.ForeColor = System.Drawing.Color.Green;
            this.tbInitCat.Location = new System.Drawing.Point(226, 72);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(298, 22);
            this.tbInitCat.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(540, 69);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 28);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // datGridDBTables
            // 
            this.datGridDBTables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.datGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridDBTables.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.datGridDBTables.Location = new System.Drawing.Point(22, 123);
            this.datGridDBTables.Name = "datGridDBTables";
            this.datGridDBTables.RowHeadersWidth = 51;
            this.datGridDBTables.RowTemplate.Height = 24;
            this.datGridDBTables.Size = new System.Drawing.Size(629, 187);
            this.datGridDBTables.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "SQL Request";
            // 
            // tbRequest
            // 
            this.tbRequest.ForeColor = System.Drawing.Color.Blue;
            this.tbRequest.Location = new System.Drawing.Point(226, 332);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(298, 22);
            this.tbRequest.TabIndex = 7;
            // 
            // btnRequest
            // 
            this.btnRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Location = new System.Drawing.Point(540, 330);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(111, 28);
            this.btnRequest.TabIndex = 8;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.datGridSQLResult.Location = new System.Drawing.Point(23, 373);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.RowHeadersWidth = 51;
            this.datGridSQLResult.RowTemplate.Height = 24;
            this.datGridSQLResult.Size = new System.Drawing.Size(629, 187);
            this.datGridSQLResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 582);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datGridDBTables);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox tbDatSource;
        protected internal System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView datGridDBTables;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView datGridSQLResult;



    }
}

