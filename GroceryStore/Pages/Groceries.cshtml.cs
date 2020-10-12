using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryStore.Pages
{
    public class FruitsPageModel : PageModel
    {
        public List<GroceryItem> Foods = Inventory.Fruits();

        public void OnGet()
        {

        }
    }
}
