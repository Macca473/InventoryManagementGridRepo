using InventoryManagementGrid.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers.PathFindngUtil
{
    public class MakeGridUtil
    {
        public static List<Sq> MakeGridUtilM(int width, int depth)
        {
            //List<List<Sq>> GridLocs = new List<List<Sq>>();

            List<Sq> GridLocs = new List<Sq>();

            for (int dep = 0; dep < depth; dep++)
            {
                //List<Sq> WidthLocs = new List<Sq>();

                for (int wit = 0; wit < width; wit++)
                {
                    Sq thissq = new Sq(dep, wit);

                    if(Addiskeepclears(thissq, depth, width))
                    {
                        thissq.iskeepclear = true;
                    }

                    //WidthLocs.Add(thissq);

                    //Console.WriteLine(thissq.depth + " " + thissq.width);

                    GridLocs.Add(thissq);
                }
                
            }
            return GridLocs;
        }

        public static bool Addiskeepclears(Sq tSq, int D, int W)
        {
            if (tSq.width == 0 || tSq.width == W || tSq.depth == 0 || tSq.depth == D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
