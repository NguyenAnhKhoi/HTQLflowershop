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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.saveBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.editBt = new System.Windows.Forms.Button();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.dataGridView1);
            this.tablePanel.Location = new System.Drawing.Point(12, 183);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 320);
            this.tablePanel.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdID,
            this.OrdDate,
            this.CustName,
            this.OrdCost,
            this.EmID,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(555, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 20);
            this.textBox5.TabIndex = 9;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(300, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 5;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 2;
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
            this.controlPanel.Controls.Add(this.editBt);
            this.controlPanel.Controls.Add(this.saveBt);
            this.controlPanel.Controls.Add(this.addBt);
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Location = new System.Drawing.Point(12, 40);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 9;
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(167, 3);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(75, 37);
            this.saveBt.TabIndex = 2;
            this.saveBt.Text = "Lưu";
            this.saveBt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
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
            // OrdID
            // 
            this.OrdID.HeaderText = "Mã HĐ";
            this.OrdID.Name = "OrdID";
            this.OrdID.Width = 75;
            // 
            // OrdDate
            // 
            this.OrdDate.HeaderText = "Ngày thanh toán";
            this.OrdDate.Name = "OrdDate";
            this.OrdDate.Width = 150;
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Tên KH";
            this.CustName.Name = "CustName";
            this.CustName.Width = 200;
            // 
            // OrdCost
            // 
            this.OrdCost.HeaderText = "Thành tiền";
            this.OrdCost.Name = "OrdCost";
            // 
            // EmID
            // 
            this.EmID.HeaderText = "MãNV";
            this.EmID.Name = "EmID";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(86, 3);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(75, 37);
            this.editBt.TabIndex = 3;
            this.editBt.Text = "Sửa";
            this.editBt.UseVisualStyleBackColor = true;
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
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmID;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button editBt;
    }
}