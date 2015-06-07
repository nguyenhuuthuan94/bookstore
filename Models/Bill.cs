using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public String MaHD { get; set; }
        public String MaKH { get; set; }
        public DateTime NgayLap { get; set; }
    }
}