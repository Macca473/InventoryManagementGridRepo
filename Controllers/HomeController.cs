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
            conn.Close();

            return list;
        }

        public void PutTTable(MySqlConnection conn, string? inpst)
        {
            List<t_table> list = new List<t_table>();

            if(inpst != null)
            {
                try
                {
                    //{ inpst }

                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO gridinv_db.t_table (`test_var`) VALUES('{inpst}'); ", conn);

                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.InnerException + " " + e.SqlState);
                }
            }
            conn.Close();
        }
    }
}
