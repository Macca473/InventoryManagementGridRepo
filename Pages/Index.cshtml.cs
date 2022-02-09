using InventoryManagementGrid.DBContext;
using InventoryManagementGrid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            InventoryManagementGrid.Controllers.HomeController HomeController = new();

            ActionResult<List<t_table>> actionResult = HomeController.GetTestTable();

            List<t_table> TList = actionResult.Value;

            Console.WriteLine("INX: " + TList[1].test_var);



        }
    }
}
