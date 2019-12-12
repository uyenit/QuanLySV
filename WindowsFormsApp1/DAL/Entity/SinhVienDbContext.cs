
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL.Entity;

namespace QuanLySV.DAL
{
    public class SinhVienDbContext : DbContext
    {
        public SinhVienDbContext() : base("Data Source=.;Initial Catalog=QLSV;User ID=sa;Password=123456")
        {

        }
        public DbSet<SinhVien> SinhVienDbset { get; set; }
        public DbSet<DiemHocTap> DiemHocTapDbset { get; set; }
        public DbSet<Nganh> NganhDbset { get; set; }

    }
}
