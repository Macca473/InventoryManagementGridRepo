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

        static void Inptwn(Sq S1, Sq S2)
        {
            Sq twn1 = new Sq(S1.width, S2.depth);

            Sq twn2 = new Sq(S2.width, S1.depth);

            //Console.WriteLine("Input Num1: W" + S1.width + "D:" + S1.depth + " Input Num1: W" + S2.width + "D:" + S2.depth);
            //Console.WriteLine("Output Num1: W" + twn1.width + "D:" + twn1.depth + " Output Num1: W" + twn2.width + "D:" + twn2.depth);

            //List<Sq> Inpt = new List<Sq>();

            Console.WriteLine(SqList.Count);

            //List<Sq> Inpt = Inb(S1, twn1);

            List<Sq> Inpt = Inb(twn1, S1);

            for (int inx = 0; inx < Inpt.Count; inx++)
            {
                Console.WriteLine(Inpt[inx].width + " | " + Inpt[inx].depth);
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
