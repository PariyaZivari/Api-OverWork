using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OverWorkApi.Interfaces;

namespace OverWorkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private IUnitsRepository _unitRepository;
        public UnitsController(IUnitsRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }
        [HttpGet]
        public IActionResult GetUnits()
        {
            //ارسال کد وضعیت صحیح به برنامه
            var result = new ObjectResult(_unitRepository.Getall())
            {
                StatusCode = (int)HttpStatusCode.OK
            };
            return result;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnits([FromRoute] int unitcode)
        {
            if (await UnitsExists(unitcode))
            {
                var units = await _unitRepository.Find(unitcode);
                return Ok(units);
            }
            else
            {
                return NotFound();
            }

        }
        private async Task<bool> UnitsExists(int unitcode)
        {
            return await _unitRepository.IsExists(unitcode);
        }

        [HttpPost]
        public async Task<IActionResult> PostUnits([FromBody] Units units)
        {
            //چک کردن صحیح بودن اجبارهای فیلدها
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _unitRepository.Add(units);
            return CreatedAtAction("GetUnits", new { unitcode = units.UnitCode }, units);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnits([FromRoute] int unitcode, [FromBody] Units units)
        {
            await _unitRepository.Update(units);
            return Ok(units);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnits([FromRoute] int unitcode)
        {
            await _unitRepository.Remove(unitcode);
            return Ok();
        }
      
    }
}
