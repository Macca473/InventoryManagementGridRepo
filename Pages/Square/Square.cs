using InventoryManagementGrid.DBContext;
using InventoryManagementGrid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Square
{
    public class SquareModel : PageModel
    {
        Sq thisSq { get; set; }

        public void SendSq(Sq TSq)
        {
            thisSq = TSq;
        }
    }
}
