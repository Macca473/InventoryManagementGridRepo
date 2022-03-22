//using InventoryManagementGrid.DBContext;
//using InventoryManagementGrid.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace InventoryManagementGrid.LeftSide
//{
//    public class LeftSideModel : PageModel
//    {
//        [BindProperty]
//        public List<t_table> TList { get; set; }
//        [BindProperty]
//        public string Inpstring { get; set; }
//        [BindProperty]

//        private readonly ILogger<LeftSideModel> _logger;

//        public LeftSideModel(ILogger<LeftSideModel> logger)
//        {
//            _logger = logger;
//        }

//        //public IActionResult OnPost()
//        //{
//        //    Inpstring = Request.Form["Inpstring"];

//        //    @ViewData["InpString"] = Inpstring;

//        //    GetTestVals();

//        //    return Page();
//        //}

//        public object Dothing()
//        {
//            Console.WriteLine("Dothing: " + Inpstring);

//            //GetTestVals();

//        }

//        public void GetTestVals()
//        {
//            InvGridDbContext _InvGridDbContext = (InvGridDbContext)HttpContext.RequestServices.GetService(typeof(InvGridDbContext));

//            Controllers.HomeController HomeController = new();

//            HomeController.PutTTable(_InvGridDbContext.GetConnection(), Inpstring);

//            TList = HomeController.GetTTable(_InvGridDbContext.GetConnection());
//        }
//    }
//}
