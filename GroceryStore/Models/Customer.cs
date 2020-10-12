using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryStore.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please write your First name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please write your Last name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string LastName { get; set; }

        [Required, StringLength(30, MinimumLength = 10, ErrorMessage = "Minimum 10 characters.")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
    }
}