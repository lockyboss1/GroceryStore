using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryStore.Pages
{
    public class DetailsModel : PageModel
    {
        public GroceryItem CurrentFood = new GroceryItem();
        public List<GroceryItem> Foods = Inventory.ToList();

        public async Task<IActionResult> OnGetAsync(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            CurrentFood = Foods.Find(x => x.Name == name);

            return Page();
        }
    }
}
