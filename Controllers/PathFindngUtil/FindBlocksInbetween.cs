using InventoryManagementGrid.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers.PathFindngUtil
{
    public class FindInbetweenUtil
    {
        static List<Sq> Inptwn(Sq S1, Sq S2)
        {
            Sq twn1 = new Sq(S1.depth, S2.width);

            Sq twn2 = new Sq(S2.depth, S1.width);

            //SqList[S1.depth][S1.width].isgoal = true;

            //SqList[S2.depth][S2.width].isgoal = true;

            //SqList[twn1.depth][twn1.width].isgoal = true;

            //SqList[twn2.depth][twn2.width].isgoal = true;

            List<Sq> ToMove = new List<Sq>();

            List<Sq> Inpt = Inb(S1, twn1);

            Inpt.AddRange(Inb(S2, twn1));

            if (Inpt.Any(x => x.isblocked == true))
            {
                Inpt.Clear();

                Inpt.AddRange(Inb(S1, twn2));

                Inpt.AddRange(Inb(S2, twn2));
            }

            for (int inx = 0; inx < Inpt.Count; inx++)
            {
                Lists.SqList[Inpt[inx].depth][Inpt[inx].width].iscurrPath = true;

                if (Inpt[inx].DW != S1.DW && Inpt[inx].DW != S2.DW && Inpt[inx].DW != twn1.DW && Inpt[inx].DW != twn2.DW)
                {
                    Lists.SqList[Inpt[inx].depth][Inpt[inx].width].istobemoved = true;

                    ToMove.Add(Lists.SqList[Inpt[inx].depth][Inpt[inx].width]);
                }
            }

            return ToMove;
        }

        static List<Sq> Inb(Sq S1, Sq S2)
        {

            List<Sq> SortInp = new List<Sq>() { S1, S2 }.OrderBy(x => x.depth).OrderBy(x => x.width).ToList();

            List<Sq> Inpt = new List<Sq>();

            for (int D = 0; D < Lists.SqList.Count; D++)
            {
                for (int W = 0; W < Lists.SqList[D].Count; W++)
                {
                    if (Lists.SqList[D][W].width <= SortInp[1].width && Lists.SqList[D][W].width >= SortInp[0].width && Lists.SqList[D][W].depth <= SortInp[1].depth && Lists.SqList[D][W].depth >= SortInp[0].depth)
                    {
                        Inpt.Add(Lists.SqList[D][W]);
                    }
                }
            }

            return Inpt;
        }
    }
}
