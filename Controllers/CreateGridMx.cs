using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers
{
    public class CreateGridMx : Controller
    {
        public class Sq
        {
            public int width { get; set; }
            public int depth { get; set; }
            public bool isgoal { get; set; }
            public bool isfilled { get; set; }
            public int goaldis { get; set; }
        }

        static List<string> MakeGrid(int width, int depth)
        {
            List<string> GridLocs = new List<string>();

            for (int wit = 0; wit < width; wit++)
            {

                for (int dep = 0; dep < width; dep++)
                {
                    GridLocs.Add("W" + wit + ":D" + dep);
                }
            }
            return GridLocs;
        }
    }

    
}
