using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Customer
    {
        public int Id{ get; set; }
        public String MaKH{ get; set; }
        public String TenKH{ get; set; }
        public String DiaChi{ get; set; }
        public String DienThoai{ get; set; }
    }
}