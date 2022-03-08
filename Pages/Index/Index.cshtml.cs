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

namespace InventoryManagementGrid.Index
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<t_table> TList { get; set; }
        [BindProperty]
        public string Inpstring { get; set; }
        [BindProperty]
        public List<Sq> Grid { get; set; }
        public int TMPD { get; set; } = 10;

        public int TMPW { get; set; } = 10;

        public string ColumnStrings { get; set; }

        public void DefColumnStrings()
        {
            string ToReturn = "";

            for(int inx = 0; inx < TMPW; inx++)
            {
                ToReturn += " auto";
            }

            ColumnStrings = ToReturn;
        }

        public string TString { get; set; } = "TestString";

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            //GetTestVals();

            DefColumnStrings();

            LoadGrid();

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

        public void LoadGrid()
        {
            InvGridDbContext _InvGridDbContext = (InvGridDbContext)HttpContext.RequestServices.GetService(typeof(InvGridDbContext));

            Controllers.GridController GridController = new();

            Grid = GridController.GetGrid(_InvGridDbContext.GetConnection());
        }

        public void GetTestVals()
        {
            InvGridDbContext _InvGridDbContext = (InvGridDbContext)HttpContext.RequestServices.GetService(typeof(InvGridDbContext));

            Controllers.HomeController HomeController = new();

            HomeController.PutTTable(_InvGridDbContext.GetConnection(), Inpstring);

            TList = HomeController.GetTTable(_InvGridDbContext.GetConnection());

            //GridController.MakeGrid(_InvGridDbContext.GetConnection(), 10);

            
        }
    }
}
