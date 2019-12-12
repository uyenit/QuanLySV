using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL.Entity;

namespace QuanLySV
{
    public partial class ThemSinhVien : Form
    {
        string maSinhVien;
        string hoTen;
        bool gioiTinhNam;
        DateTime ngaySinh;
        string maNganh;
        string maMonHoc1;
        string maMonHoc2;
        List<Nganh> nganh = Nganh.getnganh();
        public ThemSinhVien()
        {
            InitializeComponent();
            for (int i = 0; i < nganh.Count; i++)
            {
                comboBoxNganh.Items.Add(nganh.ElementAt(i).TenNganh);
            }

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            maSinhVien = txtMaSinhVien.Text;
            hoTen = txtHoTen.Text;
            gioiTinhNam = chkbNam.Checked;
            ngaySinh = dtpNgaySinh.Value;
            maNganh = nganh.ElementAt(comboBoxNganh.SelectedIndex).MaNganh;
   

            double diem1 = Convert.ToDouble(txtDiemMon1.Text);
            double diem2 = Convert.ToDouble(txtDiemMon2.Text);
            if ((diem1 >= 0 && diem1 <= 10) && (diem2 >= 0 && diem2 <= 10))
            {
                SinhVien sv = new SinhVien { MaNganh = maNganh,MaSinhVien = maSinhVien, HoVaTen = hoTen, GioiTinh = gioiTinhNam, NgaySinh = ngaySinh };
                SinhVien.themSinhVien(sv);
                DiemHocTap.themDiemHocTap(maSinhVien, maMonHoc1, txtDiemMon1.Text, diem1, maMonHoc2, txtDiemMon2.Text, diem2);
                MessageBox.Show("Đã thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin nhập vào không hợp lệ");
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = nganh.ElementAt(comboBoxNganh.SelectedIndex).MaNganh;
            maMonHoc1 = "";
            maMonHoc2 = "";
            switch (temp)
            {
                case "cntt":
                    txtDiemMon1.Text = "";
                    maMonHoc1 = "cntt1";
                    txtDiemMon2.Text = "";
                    maMonHoc2 = "cntt2";
                    break;
                case "vl":
                    txtDiemMon1.Text = "";
                    maMonHoc1 = "vatly1";
                    txtDiemMon2.Text = "";
                    maMonHoc2 = "vatly2";
                    break;
                case "van":
                    txtDiemMon1.Text = "";
                    maMonHoc1 = "van1";
                    txtDiemMon2.Text = "";
                    maMonHoc2 = "van2";
                    break;
            }
        }
    }
 }

