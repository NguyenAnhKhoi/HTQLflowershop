﻿namespace HTQL
{
    partial class ManProduct
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
            this.proTxt = new System.Windows.Forms.TextBox();
            this.sellTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.editBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBt = new System.Windows.Forms.Button();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proTxt
            // 
            this.proTxt.Location = new System.Drawing.Point(302, 58);
            this.proTxt.Name = "proTxt";
            this.proTxt.Size = new System.Drawing.Size(189, 20);
            this.proTxt.TabIndex = 7;
            // 
            // sellTxt
            // 
            this.sellTxt.Location = new System.Drawing.Point(55, 58);
            this.sellTxt.Name = "sellTxt";
            this.sellTxt.Size = new System.Drawing.Size(144, 20);
            this.sellTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá:";
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
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên HH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HH:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(302, 24);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(350, 20);
            this.nameTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProID,
            this.ProName,
            this.ProPrice,
            this.SuppID,
            this.Delete});
            this.dgvPro.Location = new System.Drawing.Point(3, 3);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.Size = new System.Drawing.Size(770, 314);
            this.dgvPro.TabIndex = 0;
            this.dgvPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPro_CellContentClick);
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.dgvPro);
            this.tablePanel.Location = new System.Drawing.Point(12, 184);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 320);
            this.tablePanel.TabIndex = 4;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.editBt);
            this.controlPanel.Controls.Add(this.groupBox1);
            this.controlPanel.Controls.Add(this.addBt);
            this.controlPanel.Location = new System.Drawing.Point(12, 41);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(776, 137);
            this.controlPanel.TabIndex = 3;
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(86, 3);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(75, 37);
            this.editBt.TabIndex = 10;
            this.editBt.Text = "Sửa";
            this.editBt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proTxt);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.sellTxt);
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
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(5, 3);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 37);
            this.addBt.TabIndex = 8;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // ProID
            // 
            this.ProID.DataPropertyName = "ProductID";
            this.ProID.HeaderText = "Mã hàng hóa";
            this.ProID.Name = "ProID";
            this.ProID.Width = 150;
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "ProductName";
            this.ProName.HeaderText = "Tên hàng hóa";
            this.ProName.Name = "ProName";
            this.ProName.Width = 250;
            // 
            // ProPrice
            // 
            this.ProPrice.DataPropertyName = "SellingPrice";
            this.ProPrice.HeaderText = "Đơn giá";
            this.ProPrice.Name = "ProPrice";
            // 
            // SuppID
            // 
            this.SuppID.DataPropertyName = "SupId";
            this.SuppID.HeaderText = "Mã nhà cung cấp";
            this.SuppID.Name = "SuppID";
            this.SuppID.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // ManProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "ManProduct";
            this.Text = "ManProduct";
            this.Load += new System.EventHandler(this.ManProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox proTxt;
        private System.Windows.Forms.TextBox sellTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppID;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}