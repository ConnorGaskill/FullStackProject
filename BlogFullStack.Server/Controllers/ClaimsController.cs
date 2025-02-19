using BlogFullStack.Server.Areas.Identity.Data;
using BlogFullStack.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogFullStack.Server.Controllers
{

    public class Taco
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly BlogFullStackServerContext _context;
        private readonly UserManager<BlogUser> _userManager;
        private List<Taco> _tacoList;
        public ClaimsController(BlogFullStackServerContext ctx, UserManager<BlogUser> usr)
        {
            //bind context/services for use in the controller
            _context = ctx;
            _userManager = usr;

            _tacoList = new List<Taco>();

            _tacoList.Add(new Taco { ID=1,  Name = "Soft Taco", Price = 0.99F});
            _tacoList.Add(new Taco { ID = 2, Name = "Hard Taco", Price = 0.89F });
            _tacoList.Add(new Taco { ID = 3, Name = "Crunch Wrap Supreme", Price = 3.00F });
        }

        [HttpGet]
        public async Task<ActionResult<ClaimsPrincipal>> Get()
        {
            return User;
        }


    }

}
