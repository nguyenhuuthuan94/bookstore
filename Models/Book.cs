using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public String MaSach { get; set; }
        public String TenSach { get; set; }
        public String TacGia { get; set; }
        public String NhaXuatBan { get; set; }
        public int SoTrang { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public String TheLoaiSach { get; set; }
        public String MoTa { get; set; }
        public String Image { get; set; }
    }
}