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
    public class Loc
    {
        public int depth { get; set; }
        public int width { get; set; }
        public int DW { get; }
        public Loc(int d, int w)
        {
            try
            {
                DW = int.Parse("" + d + w);
            }
            catch { }

            depth = d;

            width = w;
        }
    }
}
