using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BillDetail
    {
        public int Id { get; set; }
        public String MaHD { get; set; }
        public String MaSach { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
    }
}