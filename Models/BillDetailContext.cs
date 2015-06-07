using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BillDetailContext:DbContext
    {
        public DbSet<BillDetail> BillDetails { get; set; }
    }
}