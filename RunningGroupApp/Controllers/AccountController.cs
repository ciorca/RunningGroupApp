using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RunningGroupApp.Data;
using RunningGroupApp.Models;
using RunningGroupApp.ViewModels;

namespace RunningGroupApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, AppDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        //THE GET PART
       public IActionResult Login()
        {
            var response = new LoginViewModel();

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            //User is found, check the password
            var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);
            if (user != null)
            {
                var passwordCheck= await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if (passwordCheck)
                {
                    //Pasword corect,sign in
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Race");
                    }

                }

                //password is incorrect
                TempData["Error"] = "Wrong data.Please retry";
                return View(loginViewModel);    
            }
            //User not found
            TempData["Error"] = "Wrong data, please retry";
            return View(loginViewModel);
        }
    }
}
