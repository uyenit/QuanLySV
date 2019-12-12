namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchInput = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnBoSung = new System.Windows.Forms.ToolStripDropDownButton();
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.gbThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.tcDiemChiTiet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVanHD = new System.Windows.Forms.TextBox();
            this.lable3 = new System.Windows.Forms.Label();
            this.txtVanCD = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVatlyDH = new System.Windows.Forms.TextBox();
            this.txtVatlycd = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHDT = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.txtLapTrinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.checkboxGioiTinh = new System.Windows.Forms.CheckBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbThongTinChiTiet.SuspendLayout();
            this.tcDiemChiTiet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchInput,
            this.btnSearch,
            this.btnCapNhat,
            this.btnXoa,
            this.btnBoSung});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(300, 25);
            this.searchInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchInput_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 22);
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCapNhat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(59, 22);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnBoSung
            // 
            this.btnBoSung.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBoSung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBoSung.Image = ((System.Drawing.Image)(resources.GetObject("btnBoSung.Image")));
            this.btnBoSung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoSung.Name = "btnBoSung";
            this.btnBoSung.Size = new System.Drawing.Size(63, 22);
            this.btnBoSung.Text = "Bổ sung";
            this.btnBoSung.Click += new System.EventHandler(this.BtnBoSung_Click);
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.Location = new System.Drawing.Point(12, 45);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(351, 368);
            this.lstSinhVien.TabIndex = 1;
            this.lstSinhVien.Click += new System.EventHandler(this.LstSinhVien_Click_1);
            // 
            // gbThongTinChiTiet
            // 
            this.gbThongTinChiTiet.Controls.Add(this.lbDiem);
            this.gbThongTinChiTiet.Controls.Add(this.tcDiemChiTiet);
            this.gbThongTinChiTiet.Controls.Add(this.txtNgaySinh);
            this.gbThongTinChiTiet.Controls.Add(this.dtpNgaySinh);
            this.gbThongTinChiTiet.Controls.Add(this.checkboxGioiTinh);
            this.gbThongTinChiTiet.Controls.Add(this.txtHoTen);
            this.gbThongTinChiTiet.Controls.Add(this.label1);
            this.gbThongTinChiTiet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbThongTinChiTiet.Location = new System.Drawing.Point(385, 45);
            this.gbThongTinChiTiet.Name = "gbThongTinChiTiet";
            this.gbThongTinChiTiet.Size = new System.Drawing.Size(414, 400);
            this.gbThongTinChiTiet.TabIndex = 2;
            this.gbThongTinChiTiet.TabStop = false;
            this.gbThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(23, 363);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(32, 13);
            this.lbDiem.TabIndex = 6;
            this.lbDiem.Text = "ĐTB:";
            // 
            // tcDiemChiTiet
            // 
            this.tcDiemChiTiet.Controls.Add(this.tabPage1);
            this.tcDiemChiTiet.Controls.Add(this.tabPage2);
            this.tcDiemChiTiet.Controls.Add(this.tabPage3);
            this.tcDiemChiTiet.Location = new System.Drawing.Point(23, 175);
            this.tcDiemChiTiet.Name = "tcDiemChiTiet";
            this.tcDiemChiTiet.SelectedIndex = 0;
            this.tcDiemChiTiet.Size = new System.Drawing.Size(237, 165);
            this.tcDiemChiTiet.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtVanHD);
            this.tabPage1.Controls.Add(this.lable3);
            this.tabPage1.Controls.Add(this.txtVanCD);
            this.tabPage1.Controls.Add(this.lable2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(229, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Văn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVanHD
            // 
            this.txtVanHD.Location = new System.Drawing.Point(84, 71);
            this.txtVanHD.Name = "txtVanHD";
            this.txtVanHD.Size = new System.Drawing.Size(112, 20);
            this.txtVanHD.TabIndex = 3;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(14, 74);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(45, 13);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Văn HĐ";
            // 
            // txtVanCD
            // 
            this.txtVanCD.Location = new System.Drawing.Point(84, 34);
            this.txtVanCD.Name = "txtVanCD";
            this.txtVanCD.Size = new System.Drawing.Size(112, 20);
            this.txtVanCD.TabIndex = 1;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(14, 37);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(44, 13);
            this.lable2.TabIndex = 0;
            this.lable2.Text = "Văn CĐ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtVatlyDH);
            this.tabPage2.Controls.Add(this.txtVatlycd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(229, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vật lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vật lý ĐH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vật lý cd";
            // 
            // txtVatlyDH
            // 
            this.txtVatlyDH.Location = new System.Drawing.Point(66, 84);
            this.txtVatlyDH.Name = "txtVatlyDH";
            this.txtVatlyDH.Size = new System.Drawing.Size(130, 20);
            this.txtVatlyDH.TabIndex = 1;
            // 
            // txtVatlycd
            // 
            this.txtVatlycd.Location = new System.Drawing.Point(66, 37);
            this.txtVatlycd.Name = "txtVatlycd";
            this.txtVatlycd.Size = new System.Drawing.Size(130, 20);
            this.txtVatlycd.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtHDT);
            this.tabPage3.Controls.Add(this.lable4);
            this.tabPage3.Controls.Add(this.txtLapTrinh);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(229, 139);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CNTT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hướng đối tượng";
            // 
            // txtHDT
            // 
            this.txtHDT.Location = new System.Drawing.Point(93, 59);
            this.txtHDT.Name = "txtHDT";
            this.txtHDT.Size = new System.Drawing.Size(130, 20);
            this.txtHDT.TabIndex = 5;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Location = new System.Drawing.Point(14, 26);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(48, 13);
            this.lable4.TabIndex = 4;
            this.lable4.Text = "Lập trình";
            // 
            // txtLapTrinh
            // 
            this.txtLapTrinh.Location = new System.Drawing.Point(66, 23);
            this.txtLapTrinh.Name = "txtLapTrinh";
            this.txtLapTrinh.Size = new System.Drawing.Size(130, 20);
            this.txtLapTrinh.TabIndex = 3;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Location = new System.Drawing.Point(20, 94);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.txtNgaySinh.TabIndex = 4;
            this.txtNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(23, 119);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // checkboxGioiTinh
            // 
            this.checkboxGioiTinh.AutoSize = true;
            this.checkboxGioiTinh.Location = new System.Drawing.Point(23, 65);
            this.checkboxGioiTinh.Name = "checkboxGioiTinh";
            this.checkboxGioiTinh.Size = new System.Drawing.Size(89, 17);
            this.checkboxGioiTinh.TabIndex = 2;
            this.checkboxGioiTinh.Text = "Giới tính nam";
            this.checkboxGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(76, 30);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.gbThongTinChiTiet);
            this.Controls.Add(this.lstSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbThongTinChiTiet.ResumeLayout(false);
            this.gbThongTinChiTiet.PerformLayout();
            this.tcDiemChiTiet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox searchInput;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripDropDownButton btnBoSung;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.GroupBox gbThongTinChiTiet;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.TabControl tcDiemChiTiet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox checkboxGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVanHD;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox txtVanCD;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVatlyDH;
        private System.Windows.Forms.TextBox txtVatlycd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHDT;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.TextBox txtLapTrinh;
    }
}

