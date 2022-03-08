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

        public List<Sq> GetGrid(MySqlConnection conn)
        {
            List<Sq> Grid = new List<Sq>();

                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from grids", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long tmpItemID = 0;

                            if (!(reader["item_id"] is DBNull))
                            {
                                tmpItemID = Convert.ToInt64(reader["item_id"]);
                            }

                            Grid.Add(new Sq(Convert.ToInt32(reader["depth"]), Convert.ToInt32(reader["width"]))
                            {
                                ItemID = tmpItemID,
                                isblocked = Convert.ToBoolean(reader["isblocked"]),
                                iskeepclear = Convert.ToBoolean(reader["iskeepclear"]),
                            });
                        }
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.InnerException + " " + e.SqlState);
                }
            conn.Close();

            return Grid;
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
