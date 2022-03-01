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

            public bool Path { get; set; } = false;

            public Sq(int w, int d)
            {
                width = w;
                depth = d;
            }
        }

        public static List<List<Sq>> SqList { get; set; }

    }

    
}
