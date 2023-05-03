using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Hotel_system.Models;
using Microsoft.AspNetCore.Http;

namespace Hotel_system.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login ( [FromBody] LoginData loginData)
        {


            

        var user = await _userManager.FindByNameAsync(loginData.userName);

            if (user != null) {
                var result = await _signInManager.PasswordSignInAsync(user, loginData.password, false,false);

                if (result.Succeeded) {


                    List<string> optionList = new List<string> { "You loged in succesfully" , user.UserName };

                    //HttpContext.Session.SetString("user", user.UserName);

                    return Ok(optionList);
                
                }

            }

            return Ok("good result");
        }
        //public IActionResult Logedin()
        //{




        //    return View();
        //}

        [HttpGet]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();




            return Ok("you Loged out");

        }


   




        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] LoginData loginData)
        {
            List<string> les = new List<string> { "You registered succesfully" };

            if (loginData.userName != null) {

                Task<IdentityUser> us = _userManager.FindByNameAsync(loginData.userName);

                if (us.Result == null)
                {

                    var user = new IdentityUser() { UserName = loginData.userName };
                  

                    if (loginData.password != null)
                    {

                        var result = await _userManager.CreateAsync(user, loginData.password);

                        if (result.Succeeded)
                        {

                            await _signInManager.SignInAsync(user, false);

                            ////HttpContext.Session.SetString("userName", user.UserName);

                            return Ok(les);





                        }

                    }

                }



            }



            List<string> less = new List<string> { "this user name is used before" };


            return NotFound(less);
        }

    }
}
