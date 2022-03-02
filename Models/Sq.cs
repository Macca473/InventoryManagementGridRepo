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
    public class Sq
    {
        public int DW { get; set; }
        public long Uid { get; set; }
        public int depth { get; set; }
        public int width { get; set; }
        public bool isgoal { get; set; } = false;
        public bool isfilled { get; set; } = false;
        public long ItemID { get; set; }
        public int goaldis { get; set; } = 0;
        public bool isblocked { get; set; } = false;
        public bool istobemoved { get; set; } = false;
        public bool iscurrPath { get; set; } = false;

        public Sq(int d, int w)
        {
            Uid = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds() / (w * d + 1);

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
