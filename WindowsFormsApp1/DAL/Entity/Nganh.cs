using QuanLySV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL.Entity
{
    public class Nganh
    {
        [Key]
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
        public static List<Nganh> getnganh()
        {
            List<Nganh> list = new SinhVienDbContext().NganhDbset.Select(e => e).ToList();
            return list;
        }
    }
   
}
