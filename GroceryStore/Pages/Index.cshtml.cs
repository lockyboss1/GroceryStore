using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GroceryStore.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Rating { get; set; }

        [BindProperty]
        public string Feedback { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }   

        public void OnGet()
        {
            
            
        }
    }
}
