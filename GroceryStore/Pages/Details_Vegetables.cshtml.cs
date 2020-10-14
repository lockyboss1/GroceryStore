using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryStore.Pages
{
    public class Details_VegetablesModel : PageModel
    {
        public List<GroceryItem> Vegetable = MyVegetables.Vegetables();
        public GroceryItem CurrentFood = new GroceryItem();


        public async Task<IActionResult> OnGetAsync(string name)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} {name}");
            }

            if (name == null)
            {
                return NotFound();
            }

            CurrentFood = Vegetable.Find(x => x.Name == name);

            return Page();
        }
    }
}
