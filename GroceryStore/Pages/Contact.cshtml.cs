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
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        } 

        public async Task<IActionResult> OnPostAsync(string Name)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (StreamWriter writer = new StreamWriter("Contact.txt", append: true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} {Name}");
            }

            return RedirectToPage("./Index");
        }
    }
}
