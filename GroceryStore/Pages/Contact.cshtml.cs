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

        public void OnGet()
        {    
        }

        public async Task<IActionResult> OnPostAsync()
        {
            using (StreamWriter writer = new StreamWriter("Contact.txt", append: true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} {Customer.FirstName}, {Customer.LastName}, {Customer.Email}, {Customer.Text}");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            else
            {
                TempData["Message"] = "Message Sent";
                return RedirectToAction("Contact", "Home");
            }
        }
    }
}
