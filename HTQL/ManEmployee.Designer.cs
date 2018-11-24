namespace HTQL
{
    partial class ManEmployee
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.accTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBt = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.priTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Controls.Add(this.addBt);
            this.controlPanel.Location = new System.Drawing.Point(12, 41);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.passTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.accTxt);
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
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(266, 58);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(189, 20);
            this.passTxt.TabIndex = 7;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(266, 24);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(350, 20);
            this.nameTxt.TabIndex = 6;
            // 
            // accTxt
            // 
            this.accTxt.Location = new System.Drawing.Point(55, 58);
            this.accTxt.Name = "accTxt";
            this.accTxt.Size = new System.Drawing.Size(144, 20);
            this.accTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên TK:";
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
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV:";
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(3, 3);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 37);
            this.addBt.TabIndex = 8;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.dgv);
            this.tablePanel.Location = new System.Drawing.Point(12, 184);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 320);
            this.tablePanel.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmID,
            this.EmName,
            this.accName,
            this.Password,
            this.privilege,
            this.Delete});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(770, 314);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // EmID
            // 
            this.EmID.DataPropertyName = "emId";
            this.EmID.HeaderText = "Mã NV";
            this.EmID.Name = "EmID";
            // 
            // EmName
            // 
            this.EmName.DataPropertyName = "emName";
            this.EmName.HeaderText = "Tên NV";
            this.EmName.Name = "EmName";
            this.EmName.Width = 300;
            // 
            // accName
            // 
            this.accName.DataPropertyName = "accName";
            this.accName.HeaderText = "Tên tài khoản";
            this.accName.Name = "accName";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            // 
            // privilege
            // 
            this.privilege.DataPropertyName = "privilege";
            this.privilege.HeaderText = "Quyền sử dụng";
            this.privilege.Name = "privilege";
            this.privilege.Width = 75;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xoá";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // priTxt
            // 
            this.priTxt.Location = new System.Drawing.Point(552, 58);
            this.priTxt.Name = "priTxt";
            this.priTxt.Size = new System.Drawing.Size(189, 20);
            this.priTxt.TabIndex = 9;
            this.priTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quyền sử dụng: ";
            // 
            // ManEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "ManEmployee";
            this.Text = "ManEmployee";
            this.Load += new System.EventHandler(this.ManEmployee_Load);
            this.controlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox accTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilege;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox priTxt;
        private System.Windows.Forms.Label label6;
    }
}