using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiTest.Models;
using OverWorkApi.Interfaces;

namespace OverWorkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficialController : ControllerBase
    {
        private IOfficialRepository _officialRepository;
        public OfficialController(IOfficialRepository officialRepository)
        {
            _officialRepository = officialRepository;
        }
        [HttpGet]
        public IEnumerable<OverworkOfficial> GetOfficial()
        {
            return _officialRepository.Getall();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOfficial([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var official = await _officialRepository.Find(id);

            if (official == null)
            {
                return NotFound();
            }

            return Ok(official);

        }
        private async Task<bool> OfficialExists(int id)
        {
            return await _officialRepository.IsExists(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostOfficial([FromBody] OverworkOfficial official)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _officialRepository.Add(official);
            return CreatedAtAction("GetOfficial", new { id = official.Id }, official);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutOfficial([FromRoute] int id, [FromBody] OverworkOfficial official)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(id != official.Id)
            {
                return BadRequest();
            }
            await _officialRepository.Update(official);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfficial([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var official = await _officialRepository.Find(id);
            if (official == null)
            {
                return NotFound();
            }

            await _officialRepository.Remove(id);

            return Ok(official);
        }


        [HttpGet("GetOfficialInDate", Name = "GetOfficialInDate")]
        public IEnumerable<OverworkOfficial> GetOfficialInDate()
        {

            return _officialRepository.Getall().Where(o => o.FromDate =="1400/05/01" && o.UnitCode == 104) ;
        }
    }

}
