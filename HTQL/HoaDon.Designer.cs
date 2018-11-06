namespace HTQL
{
    partial class HoaDon
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
            this.listHoaDon = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.adrTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phnNumTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richResult = new System.Windows.Forms.RichTextBox();
            this.flo1 = new System.Windows.Forms.Label();
            this.flo2 = new System.Windows.Forms.Label();
            this.flo3 = new System.Windows.Forms.Label();
            this.flo4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listHoaDon
            // 
            this.listHoaDon.Location = new System.Drawing.Point(12, 205);
            this.listHoaDon.Name = "listHoaDon";
            this.listHoaDon.Size = new System.Drawing.Size(153, 275);
            this.listHoaDon.TabIndex = 0;
            this.listHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(96, 37);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(167, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            // 
            // adrTxt
            // 
            this.adrTxt.Location = new System.Drawing.Point(96, 89);
            this.adrTxt.Name = "adrTxt";
            this.adrTxt.Size = new System.Drawing.Size(309, 20);
            this.adrTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại:";
            // 
            // phnNumTxt
            // 
            this.phnNumTxt.Location = new System.Drawing.Point(96, 115);
            this.phnNumTxt.Name = "phnNumTxt";
            this.phnNumTxt.Size = new System.Drawing.Size(309, 20);
            this.phnNumTxt.TabIndex = 9;
            this.phnNumTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thông tin hóa đơn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gửi phiếu thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richResult
            // 
            this.richResult.Location = new System.Drawing.Point(171, 205);
            this.richResult.Name = "richResult";
            this.richResult.Size = new System.Drawing.Size(307, 275);
            this.richResult.TabIndex = 12;
            this.richResult.Text = "";
            // 
            // flo1
            // 
            this.flo1.AutoSize = true;
            this.flo1.Location = new System.Drawing.Point(261, 147);
            this.flo1.Name = "flo1";
            this.flo1.Size = new System.Drawing.Size(35, 13);
            this.flo1.TabIndex = 13;
            this.flo1.Text = "label7";
            // 
            // flo2
            // 
            this.flo2.AutoSize = true;
            this.flo2.Location = new System.Drawing.Point(302, 147);
            this.flo2.Name = "flo2";
            this.flo2.Size = new System.Drawing.Size(35, 13);
            this.flo2.TabIndex = 14;
            this.flo2.Text = "label7";
            // 
            // flo3
            // 
            this.flo3.AutoSize = true;
            this.flo3.Location = new System.Drawing.Point(343, 147);
            this.flo3.Name = "flo3";
            this.flo3.Size = new System.Drawing.Size(35, 13);
            this.flo3.TabIndex = 15;
            this.flo3.Text = "label7";
            // 
            // flo4
            // 
            this.flo4.AutoSize = true;
            this.flo4.Location = new System.Drawing.Point(384, 147);
            this.flo4.Name = "flo4";
            this.flo4.Size = new System.Drawing.Size(35, 13);
            this.flo4.TabIndex = 16;
            this.flo4.Text = "label7";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 541);
            this.Controls.Add(this.flo4);
            this.Controls.Add(this.flo3);
            this.Controls.Add(this.flo2);
            this.Controls.Add(this.flo1);
            this.Controls.Add(this.richResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phnNumTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adrTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListView listHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adrTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phnNumTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richResult;
        private System.Windows.Forms.Label flo1;
        private System.Windows.Forms.Label flo2;
        private System.Windows.Forms.Label flo3;
        private System.Windows.Forms.Label flo4;
    }
}