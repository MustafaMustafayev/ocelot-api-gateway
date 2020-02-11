using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleMicroservice.Database;
using SimpleMicroservice.Database.Entities;

namespace SimpleMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DatabaseContext _ctx;
        public UserController()
        {
            _ctx = new DatabaseContext();  
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()  
        {
            return _ctx.Users.ToList();
        }

        // GET: api/User/5
        [HttpGet("userById/{id}")]
        public User Get(int id)
        {
            return _ctx.Users.Find(id);
        }

        // POST: api/User
        [HttpPost("addTeacher")]
        public async Task<IActionResult> Post([FromBody] Teacher teacher)
        {
            _ctx.Teachers.Add(teacher);
            await _ctx.SaveChangesAsync();
            return Ok(StatusCodes.Status201Created);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("deleteById/{id}")]
        public void Delete(int id)
        {
            _ctx.Users.Remove(_ctx.Users.Find(id));
        }
    }
}
