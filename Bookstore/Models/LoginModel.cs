using System;
namespace Bookstore.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        //this will save the pageURL and send them to wherever they were trying to go!
        public string ReturnUrl { get; set; }
    }
}
