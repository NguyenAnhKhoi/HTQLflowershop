namespace HTQL
{
    partial class Management
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
            this.btEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btProduct = new System.Windows.Forms.Button();
            this.btOrderDetails = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btSupplier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEmployee
            // 
            this.btEmployee.Location = new System.Drawing.Point(12, 56);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(185, 69);
            this.btEmployee.TabIndex = 0;
            this.btEmployee.Text = "Quản lý nhân viên";
            this.btEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giao diện quản lý cửa hàng";
            // 
            // btProduct
            // 
            this.btProduct.Location = new System.Drawing.Point(308, 56);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(185, 69);
            this.btProduct.TabIndex = 2;
            this.btProduct.Text = "Quản lý sản phẩm";
            this.btProduct.UseVisualStyleBackColor = true;
            // 
            // btOrderDetails
            // 
            this.btOrderDetails.Location = new System.Drawing.Point(150, 62);
            this.btOrderDetails.Name = "btOrderDetails";
            this.btOrderDetails.Size = new System.Drawing.Size(185, 69);
            this.btOrderDetails.TabIndex = 4;
            this.btOrderDetails.Text = "Quản lý thông tin hóa đơn";
            this.btOrderDetails.UseVisualStyleBackColor = true;
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(436, 62);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(185, 69);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "Quản lý hóa đơn";
            this.btOrder.UseVisualStyleBackColor = true;
            // 
            // btSupplier
            // 
            this.btSupplier.Location = new System.Drawing.Point(603, 56);
            this.btSupplier.Name = "btSupplier";
            this.btSupplier.Size = new System.Drawing.Size(185, 69);
            this.btSupplier.TabIndex = 5;
            this.btSupplier.Text = "Quản lý nhà cung cấp";
            this.btSupplier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btOrder);
            this.groupBox1.Controls.Add(this.btOrderDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSupplier);
            this.Controls.Add(this.btProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEmployee);
            this.Enabled = false;
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Button btOrderDetails;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}