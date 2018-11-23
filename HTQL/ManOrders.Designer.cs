namespace HTQL
{
    partial class ManOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBt = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.OrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empIdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.cusNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateSoldDTP = new System.Windows.Forms.DateTimePicker();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(5, 3);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 37);
            this.addBt.TabIndex = 1;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.dgv);
            this.tablePanel.Location = new System.Drawing.Point(12, 183);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 320);
            this.tablePanel.TabIndex = 10;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdID,
            this.OrdDate,
            this.CustName,
            this.OrdCost,
            this.EmID,
            this.Delete});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(770, 314);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // OrdID
            // 
            this.OrdID.DataPropertyName = "maHd";
            this.OrdID.HeaderText = "Mã HĐ";
            this.OrdID.Name = "OrdID";
            this.OrdID.Width = 75;
            // 
            // OrdDate
            // 
            this.OrdDate.DataPropertyName = "dateSold";
            this.OrdDate.HeaderText = "Ngày thanh toán";
            this.OrdDate.Name = "OrdDate";
            this.OrdDate.Width = 150;
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "cusName";
            this.CustName.HeaderText = "Tên KH";
            this.CustName.Name = "CustName";
            this.CustName.Width = 200;
            // 
            // OrdCost
            // 
            this.OrdCost.DataPropertyName = "cost";
            this.OrdCost.HeaderText = "Thành tiền";
            this.OrdCost.Name = "OrdCost";
            // 
            // EmID
            // 
            this.EmID.DataPropertyName = "empId";
            this.EmID.HeaderText = "MãNV";
            this.EmID.Name = "EmID";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "del";
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // empIdTxt
            // 
            this.empIdTxt.Location = new System.Drawing.Point(555, 24);
            this.empIdTxt.Name = "empIdTxt";
            this.empIdTxt.Size = new System.Drawing.Size(140, 20);
            this.empIdTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã NV:";
            // 
            // costTxt
            // 
            this.costTxt.Location = new System.Drawing.Point(300, 58);
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(200, 20);
            this.costTxt.TabIndex = 7;
            // 
            // cusNameTxt
            // 
            this.cusNameTxt.Location = new System.Drawing.Point(55, 58);
            this.cusNameTxt.Name = "cusNameTxt";
            this.cusNameTxt.Size = new System.Drawing.Size(144, 20);
            this.cusNameTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thành tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên KH:";
            // 
            // recIdTxt
            // 
            this.recIdTxt.Location = new System.Drawing.Point(55, 24);
            this.recIdTxt.Name = "recIdTxt";
            this.recIdTxt.Size = new System.Drawing.Size(144, 20);
            this.recIdTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày thanh toán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ:";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.addBt);
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Location = new System.Drawing.Point(12, 40);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateSoldDTP);
            this.groupBox1.Controls.Add(this.empIdTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.costTxt);
            this.groupBox1.Controls.Add(this.cusNameTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.recIdTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm/sửa";
            // 
            // dateSoldDTP
            // 
            this.dateSoldDTP.Location = new System.Drawing.Point(300, 24);
            this.dateSoldDTP.Name = "dateSoldDTP";
            this.dateSoldDTP.Size = new System.Drawing.Size(200, 20);
            this.dateSoldDTP.TabIndex = 3;
            // 
            // ManOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlPanel);
            this.Name = "ManOrders";
            this.Text = "ManOrders";
            this.Load += new System.EventHandler(this.ManOrders_Load);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox empIdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.TextBox cusNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateSoldDTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmID;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}