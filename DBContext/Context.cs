using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryManagementGrid.Models;
using MySqlConnector;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace InventoryManagementGrid.DBContext
{
    public class InvGridDbContext: DbContext
    {
        //public InvGridDbContext(DbContextOptions<InvGridDbContext> options) : base(options)
        //{

        //}

        //public DbSet<InventoryManagementGrid.Models.t_table> t_table { get; set; }

        public string ConnectionString { get; set; }

        public InvGridDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;

            Console.WriteLine("Running InvGridDbContext: " + ConnectionString);
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(this.ConnectionString);
        }
    }
}