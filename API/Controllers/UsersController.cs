using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext _context { get; }
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        // public ActionResult <IEnumerable<AppUser>> GetUsers()
        // {
        //     var users=_context.Users.ToList();
        //     return users;
        // }

        //wwhen using async await
        public  async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //var users= _context.Users.ToListAsync().Result;
            var users= await _context.Users.ToListAsync();
            return users;
        }

        //api/users/3
        [HttpGet("{id}")]
        public  async Task<ActionResult <AppUser>> GetUser(int id)
        {
         return await _context.Users.FindAsync(id);
        }


    }
}