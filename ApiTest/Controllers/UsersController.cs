using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OverWorkApi.Interfaces;
using OverWorkApi.Repository;

namespace OverWorkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersRepository _usersRepository;

        public IActionResult GetUsers()
        {
            var result = new ObjectResult(_usersRepository.Getall())
            {
                StatusCode = (int)HttpStatusCode.OK
            };
            return result;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUsers([FromRoute] Users user)
        {
            if (await UsersExists(user))
            {
                var users = await _usersRepository.Find(user.Username);
                return Ok(users);
            }
            else
            {
                return NotFound();
            }

        }
        private async Task<bool> UsersExists(Users user)
        {
            return await _usersRepository.IsExists(user.Username);
        }

        [HttpPost]
        public async Task<IActionResult> PostUsers([FromBody] Users users)
        {
            //چک کردن صحیح بودن اجبارهای فیلدها
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _usersRepository.Add(users);
            return CreatedAtAction("GetUsers", new { username = users.Username }, users);
        }


        [HttpPut("{username}")]
        public async Task<IActionResult> PutUsers([FromRoute] string username, [FromBody] Users users)
        {
            await _usersRepository.Update(users);
            return Ok(users);
        }


        [HttpDelete("{username}")]
        public async Task<IActionResult> DeleteUsers([FromRoute] string username)
        {
            await _usersRepository.Remove(username);
            return Ok();
        }
    }
}
