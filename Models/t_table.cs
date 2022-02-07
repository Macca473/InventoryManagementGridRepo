using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InventoryManagementGrid.Models
{
    public class t_table
    {
        [Key]
        public int TID { get; set; }
        public string test_var { get; set; }

        public static void Init(IServiceProvider serviceProvider)
        {
            using (DBContext.InvGridDbContext context = new DBContext.InvGridDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DBContext.InvGridDbContext>>()))
            {
                List<t_table> Tlist = context.t_table.ToList();

                Console.WriteLine("Finding stuff");

                foreach(t_table TI in Tlist)
                {
                    Console.WriteLine(TI.TID + " " + TI.test_var);
                }
            }
        }

        public t_table()
        {
            //Init();
        }
    }
}
