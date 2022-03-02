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
    class Lists
    {
        public static List<Inst> Instlist { get; set; } = new List<Inst>();

        public static List<Item> Itemlist { get; set; } = new List<Item>();

        public static List<List<Sq>> SqList { get; set; } = new List<List<Sq>>();
    }
   
}
