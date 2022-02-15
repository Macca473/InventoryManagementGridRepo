using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementGrid.Controllers
{
    public class CreateGridMx : Controller
    {

        public void CreateGridMxList()
        {
            string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            char thing = Letters[0];
        }

        public char FindLetter(int num)
        {
            string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int LL = Letters.Length;

            if (num > LL)
            {
                
            }

            return Letters[0];
        }
    }

    
}
