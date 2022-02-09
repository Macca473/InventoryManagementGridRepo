using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using MySqlConnector;
using static InventoryManagementGrid.DBContext.InvGridDbContext;
using InventoryManagementGrid.DBContext;
using Microsoft.AspNetCore.Http;

namespace InventoryManagementGrid.Models
{
    public class t_table
    {
        [Key]
        public int TID { get; set; }
        public string test_var { get; set; }
    }
}
