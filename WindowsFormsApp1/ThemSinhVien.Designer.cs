namespace QuanLySV
{
    partial class ThemSinhVien
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtDiemMon2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemMon1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNganh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkbNam = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(168, 93);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(175, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(168, 42);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(175, 20);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // txtDiemMon2
            // 
            this.txtDiemMon2.Location = new System.Drawing.Point(168, 302);
            this.txtDiemMon2.Name = "txtDiemMon2";
            this.txtDiemMon2.Size = new System.Drawing.Size(175, 20);
            this.txtDiemMon2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm Môn 1";
            // 
            // txtDiemMon1
            // 
            this.txtDiemMon1.Location = new System.Drawing.Point(168, 251);
            this.txtDiemMon1.Name = "txtDiemMon1";
            this.txtDiemMon1.Size = new System.Drawing.Size(175, 20);
            this.txtDiemMon1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm Môn 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(168, 188);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // comboBoxNganh
            // 
            this.comboBoxNganh.FormattingEnabled = true;
            this.comboBoxNganh.Location = new System.Drawing.Point(577, 45);
            this.comboBoxNganh.Name = "comboBoxNganh";
            this.comboBoxNganh.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNganh.TabIndex = 6;
            this.comboBoxNganh.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNganh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nganh";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(489, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(612, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giới Tính Nam: ";
            // 
            // chkbNam
            // 
            this.chkbNam.AutoSize = true;
            this.chkbNam.Location = new System.Drawing.Point(190, 151);
            this.chkbNam.Name = "chkbNam";
            this.chkbNam.Size = new System.Drawing.Size(15, 14);
            this.chkbNam.TabIndex = 10;
            this.chkbNam.UseVisualStyleBackColor = true;
            // 
            // ThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkbNam);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxNganh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiemMon1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.txtDiemMon2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "ThemSinhVien";
            this.Text = "ThemSinhVien";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtDiemMon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemMon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox comboBoxNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkbNam;
    }
}