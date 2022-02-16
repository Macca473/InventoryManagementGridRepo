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
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int LL = letters.Length;

            if (num > LL)
            {
                
            }

            return letters[0];
        }
    }

    
}
