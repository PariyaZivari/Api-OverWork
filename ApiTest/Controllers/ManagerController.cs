using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using OverWorkApi.Interfaces;

namespace OverWorkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ManagerController : ControllerBase
    {
        private IManagersRepository _managerRepository;
        public ManagerController(IManagersRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }
        [HttpGet]
        public IActionResult GetManager()
        {
            //ارسال کد وضعیت صحیح به برنامه
            var result = new ObjectResult(_managerRepository.Getall())
            {
                StatusCode = (int) HttpStatusCode.OK
            };
            //استفاده از header
            Request.HttpContext.Response.Headers.Add("x-Count", _managerRepository.CountManager().ToString());
            return result;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetManager([FromRoute] int id )
        {
            if (await ManagerExists(id))
            {
                var manager = await _managerRepository.Find(id);
                return Ok(manager);
            }
            else
            {
                return NotFound();
            }
           
        }
        private async Task<bool> ManagerExists(int id)
        {
            return await _managerRepository.IsExists(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostManager([FromBody] Managers managers)
        {
            //چک کردن صحیح بودن اجبارهای فیلدها
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _managerRepository.Add(managers);
            return CreatedAtAction("GetManager", new { id = managers.Id },managers );
        }


        [HttpPut("{id}")] 
        public async Task<IActionResult> PutManager([FromRoute] int id ,[FromBody]Managers managers)
        {
            await _managerRepository.Update(managers);
            return Ok(managers);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManager([FromRoute] int id)
        {
            await _managerRepository.Remove(id);
            return Ok();
        }


        //ایجاد یک متد به غیر از این ها 
        // [HttpGet("اسم و ادرس دوت بعذ از ادرس کلی " , Name ="اسم متد من")]
        [HttpGet("adminUser" , Name ="AdminName")]
        public IActionResult GetZivari()
        {

            return Content("pariya zivari");
        }

    }
}
