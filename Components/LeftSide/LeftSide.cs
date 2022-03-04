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

namespace InventoryManagementGrid.LeftSide
{
    public class LSModelViewComponent : ViewComponent
    {
        [BindProperty]
        public List<t_table> TList { get; set; }
        [BindProperty]
        public string Inpstring { get; set; }

        private readonly ILogger<LSModelViewComponent> _logger;

        public LSModelViewComponent(ILogger<LSModelViewComponent> logger)
        {
            _logger = logger;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
