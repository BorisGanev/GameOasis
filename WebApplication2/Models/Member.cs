using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        [Required(ErrorMessage = "You must enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter an email address.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter a  username.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You must enter a password.")]
        public string Password { get; set; }
    }
}