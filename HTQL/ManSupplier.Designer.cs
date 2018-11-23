namespace HTQL
{
    partial class ManSupplier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.webTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addrTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.addBt = new System.Windows.Forms.Button();
            this.SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.webTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.addrTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm/sửa";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(535, 24);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(229, 20);
            this.PhoneTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SĐT:";
            // 
            // webTxt
            // 
            this.webTxt.Location = new System.Drawing.Point(497, 58);
            this.webTxt.Name = "webTxt";
            this.webTxt.Size = new System.Drawing.Size(267, 20);
            this.webTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(265, 24);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(226, 20);
            this.nameTxt.TabIndex = 6;
            // 
            // addrTxt
            // 
            this.addrTxt.Location = new System.Drawing.Point(55, 58);
            this.addrTxt.Name = "addrTxt";
            this.addrTxt.Size = new System.Drawing.Size(381, 20);
            this.addrTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Website:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(55, 24);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(144, 20);
            this.idTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NCC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NCC:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupID,
            this.SupName,
            this.SupAddress,
            this.SupPhone,
            this.SupWebsite,
            this.Delete});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(770, 314);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.AutoGenerateColumns = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý nhà cung cấp";
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.dgv);
            this.tablePanel.Location = new System.Drawing.Point(12, 183);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 320);
            this.tablePanel.TabIndex = 7;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Controls.Add(this.addBt);
            this.controlPanel.Location = new System.Drawing.Point(12, 40);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 6;
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(9, 3);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 37);
            this.addBt.TabIndex = 10;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // SupID
            // 
            this.SupID.DataPropertyName = "supId";
            this.SupID.HeaderText = "Mã NCC";
            this.SupID.Name = "SupID";
            this.SupID.Width = 75;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "supName";
            this.SupName.HeaderText = "Tên NCC";
            this.SupName.Name = "SupName";
            // 
            // SupAddress
            // 
            this.SupAddress.DataPropertyName = "address";
            this.SupAddress.HeaderText = "Địa chỉ";
            this.SupAddress.Name = "SupAddress";
            this.SupAddress.Width = 300;
            // 
            // SupPhone
            // 
            this.SupPhone.DataPropertyName = "phoneNum";
            this.SupPhone.HeaderText = "SĐT";
            this.SupPhone.Name = "SupPhone";
            // 
            // SupWebsite
            // 
            this.SupWebsite.DataPropertyName = "website";
            this.SupWebsite.HeaderText = "Website";
            this.SupWebsite.Name = "SupWebsite";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // ManSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "ManSupplier";
            this.Text = "ManSupplier";
            this.Load += new System.EventHandler(this.ManSupplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox webTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox addrTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupWebsite;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}