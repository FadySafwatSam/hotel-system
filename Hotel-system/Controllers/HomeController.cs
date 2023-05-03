using Hotel_system.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_system.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {



        private AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        public HomeController( UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, AppDbContext context)
        {
            _context = context;
             _userManager = userManager;
            _signInManager = signInManager;

        }

       


        [HttpPost]
        [Route("DoBook")]
        public async Task<IActionResult> DoBook([FromBody] RoomInfo roomInfo)
        {

            var myRoom = _context.Rooms.FirstOrDefault(ab => ab.RoomId == Convert.ToInt32(roomInfo.RoomID)); ;

            myRoom.IsBooked = true;


            _context.Rooms.Update(myRoom);
            _context.SaveChanges();

            return Ok("good try");
        }

        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> List()
        {


            if (_signInManager.IsSignedIn(User)) {


            var result = _context.Rooms.ToList();

              var   auser  =    await _userManager.GetUserAsync(User);


                if (_context.Bookings.Any()) {


                    var has = _context.Bookings.Where(us=> us.UserId == auser.Id).ToList();

                    

                    if (has != null)
                    {
                        result.Add(new Room { Price = 0 });

                    }
                    else
                    {
                        result.Add(new Room { Price = 1 });

                    }

                }
              
           

                return Ok(result);


            }

            return NotFound();

        }

     
        
     
    }
}
