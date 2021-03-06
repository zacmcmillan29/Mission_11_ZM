using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.Controllers
{
    public class AccountController : Controller
    {


        //this is same thing we set up in the Seed data for the login!
        //attributes A.K.A. Instances!
        private UserManager<IdentityUser> userManager;

        private SignInManager<IdentityUser> signInManager;


        //Constructor!
        //gets instances of each of the things and passes in as parameters! 
        public AccountController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            userManager = um;
            signInManager = sim;
        }



        // GET: /<controller>/
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        //POST for login
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            //get the user associated with the name!
            if (ModelState.IsValid)
            {

                //trying to find the username that has been entered!
                IdentityUser user = await userManager.FindByNameAsync(loginModel.Username);

                //if we find something... 
                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    //try logging in with information!!
                    //this is if it works!!
                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Admin");
                    }
                }
            }

            //if we don't find something...
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }


        //LOGOUT!
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();

            return Redirect(returnUrl);
        }

    }

}
