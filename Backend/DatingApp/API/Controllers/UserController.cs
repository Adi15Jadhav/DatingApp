using API.Data;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        //api/user/2
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user is null)
                return NotFound();
            return Ok(user);
        }
    }
}
