using InventoryManagementGrid.DBContext;
using InventoryManagementGrid.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers
{
    public class HomeController : Controller
    {

        public List<t_table> GetTTable(MySqlConnection conn)
        {
            Console.WriteLine("Running GetTTable");

            List<t_table> list = new List<t_table>();

                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from t_table", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new t_table()
                            {
                                TID = Convert.ToInt32(reader["TID"]),
                                test_var = reader["test_var"].ToString(),
                            });
                        }
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.InnerException + " " + e.SqlState);
                }

            return list;
        }
    }
}
