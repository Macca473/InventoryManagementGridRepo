using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryManagementGrid.Models;
using MySqlConnector;

namespace InventoryManagementGrid.DBContext
{
    public class InvGridDbContext
    {
        //public InvGridDbContext(DbContextOptions<InvGridDbContext> options) : base(options)
        //{

        //}

        //public DbSet<InventoryManagementGrid.Models.t_table> t_table { get; set; }

        public string ConnectionString { get; set; }

        public InvGridDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;

            Console.WriteLine("connectionString " + connectionString);
        }

        public InvGridDbContext()
        {
            GetAllAlbums();
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        // /////////////////////////////////////

        public List<t_table> GetAllAlbums()
        {
            Console.WriteLine("Running GetAllAlbums");

                List<t_table> list = new List<t_table>();

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    //MySqlCommand cmd = new MySqlCommand("select * from t_table", conn);

                    //using (var reader = cmd.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        list.Add(new t_table()
                    //        {
                    //            TID = Convert.ToInt32(reader["TID"]),
                    //            test_var = reader["test_var"].ToString(),
                    //        });
                    //    }
                    //}
                }
                catch (MySqlConnector.MySqlException e)
                {
                    Console.WriteLine(e);
                }

            }

            foreach (t_table TT in list)
            {
                Console.WriteLine(TT.TID + ": " + TT.test_var);
            }

            return list;
        }

    }

    
}