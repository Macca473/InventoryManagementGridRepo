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
            public bool isgoal { get; set; } = false;
            public bool isfilled { get; set; } = false;
            public int goaldis { get; set; } = 0;

            public Sq(int w, int d)
            {
                width = w;
                depth = d;
            }
        }

        static List<Sq> MakeGrid(int width, int depth)
        {
            List<Sq> GridLocs = new List<Sq>();

            for (int wit = 0; wit < width; wit++)
            {
                for (int dep = 0; dep < width; dep++)
                {
                    Sq thissq = new Sq(wit, dep);

                    GridLocs.Add(thissq);

                    //Console.WriteLine(thissq.depth + " " + thissq.width);
                }
            }
            return GridLocs;
        }


    }

    
}
