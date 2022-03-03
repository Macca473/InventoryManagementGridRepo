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

namespace InventoryManagementGrid.Index.Index
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<t_table> TList { get; set; }
        [BindProperty]
        public string Inpstring { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            //GetTestVals();



            return Page();
        }

        //public IActionResult OnPost()
        //{
        //    Inpstring = Request.Form["Inpstring"];

        //    @ViewData["InpString"] = Inpstring;

        //    GetTestVals();

        //    return Page();
        //}

        public object Dothing()
        {
            Console.WriteLine("Dothing: " + Inpstring);

            GetTestVals();

            return null;
        }

        public void GetTestVals()
        {
            InvGridDbContext _InvGridDbContext = (InvGridDbContext)HttpContext.RequestServices.GetService(typeof(InvGridDbContext));

            Controllers.HomeController HomeController = new();

            Controllers.GridController GridController = new();

            HomeController.PutTTable(_InvGridDbContext.GetConnection(), Inpstring);

            TList = HomeController.GetTTable(_InvGridDbContext.GetConnection());

            //GridController.MakeGrid(_InvGridDbContext.GetConnection(),10);
        }
    }
}
