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
    public class Inst
    {
        public long InstID { get; set; }
        public string InstName { get; set; }

        public InstRelPrt StartInst { get; set; }
        public InstRelPrt EndInst { get; set; }

        public class InstRelPrt
        {
            Item thisItem { get; set; }
            Sq thisSq { get; set; }

            public InstRelPrt(Item I, Sq S)
            {
                thisItem = I;

                thisSq = S;
            }
        }

        public Inst(Sq SSq, Sq ESq, Item I)
        {
            StartInst = new InstRelPrt(I, SSq);

            EndInst = new InstRelPrt(I, ESq);

            InstName = "Move: item " + SSq.ItemID + " from " + SSq.DW + " to " + ESq.DW;
        }
    }
}
