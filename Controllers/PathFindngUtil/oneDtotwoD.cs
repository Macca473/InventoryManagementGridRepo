using InventoryManagementGrid.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers.PathFindngUtil
{
    public class oneDtotwoD
    {
        static List<List<Sq>> oneDtotwoDM(List<Sq> oneDGrid)
        {
            List<List<Sq>> SqList = new List<List<Sq>>();

            for (int inx = 0; inx < oneDGrid.Count; inx++)
            {
                int D = oneDGrid[inx].depth;

                int W = oneDGrid[inx].width;

                SqList[D][W] = oneDGrid[inx];
            }

            return SqList;
        }
    }
}
