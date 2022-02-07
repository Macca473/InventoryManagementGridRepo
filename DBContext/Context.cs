using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryManagementGrid.Models;

namespace InventoryManagementGrid.DBContext
{
    public class InvGridDbContext : DbContext
    {
        public InvGridDbContext(DbContextOptions<InvGridDbContext> options) : base(options)
        {

        }

        public DbSet<InventoryManagementGrid.Models.t_table> t_table { get; set; }
    }
}