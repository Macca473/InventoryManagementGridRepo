using InventoryManagementGrid.DBContext;
using InventoryManagementGrid.Models;
using InventoryManagementGrid.Controllers.PathFindngUtil;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers
{
    public class GridController : Controller
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

        public void MakeGrid(MySqlConnection conn, int? Size)
        {
            if(Size != null)
            {
                try
                {
                    int S = (int)Size;

                    List<Sq> GList = MakeGridUtil.MakeGridUtilM(S, S);

                    long Currtime = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();

                    conn.Open();

                    //MySqlCommand cmd = new MySqlCommand($"CALL gridinv_db.AddGrid(45,12,99);", conn);

                    string InsLstStr = "";

                    for (int inx = 0; inx < GList.Count; inx++)
                    {
                        if (inx != GList.Count)
                        {
                            InsLstStr += $"({GList[inx].depth},{GList[inx].width},{Currtime}),";
                        }
                        else
                        {
                            InsLstStr += $"({GList[inx].depth},{GList[inx].width},{Currtime});";
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO gridinv_db.grids (`depth`,`width`,`age`) VALUES {InsLstStr}", conn);
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
