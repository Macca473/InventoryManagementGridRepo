using InventoryManagementGrid.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Models
{
    public class TestModel
    {
        string test_var { get; set; }

        public static void Init(IServiceProvider service)
        {
            using (var context = new InvGridDbContext(
                service.GetRequiredService<DbContextOptions<InvGridDbContext>>()))
            {
                //List<TestModel> TestL = context.TestModel.ToList();
            }
        }

        public TestModel ()
        {
            
        }
    }
}
