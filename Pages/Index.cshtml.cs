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
        [BindProperty]
        public List<t_table> TList { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            Console.WriteLine("running OnGet");

            InvGridDbContext _InvGridDbContext = (InvGridDbContext)HttpContext.RequestServices.GetService(typeof(InvGridDbContext));

            Controllers.HomeController HomeController = new();

            if (TList == null)
            {
                TList = HomeController.GetTTable(_InvGridDbContext.GetConnection());
            }


            Console.WriteLine(TList[0].test_var);

            //List<t_table> TList = actionResult.

            foreach (t_table TT in TList)
            {
                Console.WriteLine("INX: " + TT.TID + " " + TT.test_var);
            }

            //ViewData["TList"] = TList;

            //if (!ModelState.IsValid)
            //{
                return Page();
            //}

            //_context.Customer.Add(Customer);
            //await _context.SaveChangesAsync();

            //return RedirectToPage("./Index");
        }
    }
}
