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
            this.tablePanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.controlPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.btAdd);
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Location = new System.Drawing.Point(12, 41);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 0;
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.dataGridView1);
            this.tablePanel.Location = new System.Drawing.Point(12, 184);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 320);
            this.tablePanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmID,
            this.EmName,
            this.accName,
            this.EmPassword,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm/sửa";
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
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(5, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 37);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NV:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 2;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(266, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(266, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmID
            // 
            this.EmID.HeaderText = "Mã NV";
            this.EmID.Name = "EmID";
            // 
            // EmName
            // 
            this.EmName.HeaderText = "Tên NV";
            this.EmName.Name = "EmName";
            this.EmName.Width = 300;
            // 
            // accName
            // 
            this.accName.HeaderText = "Tên tài khoản";
            this.accName.Name = "accName";
            // 
            // EmPassword
            // 
            this.EmPassword.HeaderText = "Mật khẩu";
            this.EmPassword.Name = "EmPassword";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xoá";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
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
            this.controlPanel.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmPassword;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}