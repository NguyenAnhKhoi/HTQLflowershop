namespace HTQL
{
    partial class ManOrderDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.editBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.proIdTxt = new System.Windows.Forms.TextBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maHDTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBt = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.OrdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.proNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý chi tiết hóa đơn";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.editBt);
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Controls.Add(this.addBt);
            this.controlPanel.Location = new System.Drawing.Point(12, 40);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 9;
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(90, 3);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(75, 37);
            this.editBt.TabIndex = 12;
            this.editBt.Text = "Sửa";
            this.editBt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proNameTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.proIdTxt);
            this.groupBox1.Controls.Add(this.amountTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maHDTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm/sửa";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(265, 58);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(178, 20);
            this.priceTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đơn giá:";
            // 
            // proIdTxt
            // 
            this.proIdTxt.Location = new System.Drawing.Point(265, 24);
            this.proIdTxt.Name = "proIdTxt";
            this.proIdTxt.Size = new System.Drawing.Size(178, 20);
            this.proIdTxt.TabIndex = 6;
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(55, 58);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(144, 20);
            this.amountTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng";
            // 
            // maHDTxt
            // 
            this.maHDTxt.Location = new System.Drawing.Point(55, 24);
            this.maHDTxt.Name = "maHDTxt";
            this.maHDTxt.Size = new System.Drawing.Size(144, 20);
            this.maHDTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã HH:";
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
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdID,
            this.ProID,
            this.ProName,
            this.Cost,
            this.Amount,
            this.TotalCost,
            this.Delete});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(770, 314);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // OrdID
            // 
            this.OrdID.DataPropertyName = "MaHD";
            this.OrdID.HeaderText = "Mã HĐ";
            this.OrdID.Name = "OrdID";
            this.OrdID.Width = 75;
            // 
            // ProID
            // 
            this.ProID.DataPropertyName = "ProID";
            this.ProID.HeaderText = "Mã HH";
            this.ProID.Name = "ProID";
            this.ProID.Width = 75;
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "ProName";
            this.ProName.HeaderText = "Tên HH";
            this.ProName.Name = "ProName";
            this.ProName.Width = 200;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "price";
            this.Cost.HeaderText = "Đơn giá";
            this.Cost.Name = "Cost";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Số lượng";
            this.Amount.Name = "Amount";
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "cost";
            this.TotalCost.HeaderText = "Thành tiền";
            this.TotalCost.Name = "TotalCost";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "del";
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // proNameTxt
            // 
            this.proNameTxt.Location = new System.Drawing.Point(509, 24);
            this.proNameTxt.Name = "proNameTxt";
            this.proNameTxt.Size = new System.Drawing.Size(255, 20);
            this.proNameTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên HH:";
            // 
            // ManOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.tablePanel);
            this.Name = "ManOrderDetail";
            this.Text = "ManOrderDetail";
            this.Load += new System.EventHandler(this.ManOrderDetail_Load);
            this.controlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox proIdTxt;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maHDTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox proNameTxt;
        private System.Windows.Forms.Label label5;
    }
}