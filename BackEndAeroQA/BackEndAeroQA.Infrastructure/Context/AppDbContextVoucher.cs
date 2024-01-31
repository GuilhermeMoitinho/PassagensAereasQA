using BackEndAeroQA.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAeroQA.Infrastructure.Context
{
    public class AppDbContextVoucher : DbContext
    {
        public AppDbContextVoucher(DbContextOptions<AppDbContextVoucher> op) : base(op)
        {          
        }

        public DbSet<Voucher> Vouchers { get; set; }
    }
}
