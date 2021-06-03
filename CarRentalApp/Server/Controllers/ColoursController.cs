using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApp.Server.Data;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetColours()
        {
            var colours = await _unitOfWork.MakesRepository.GetAll();
            return Ok(colours);
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColours(int id)
        {
            var colour = await _unitOfWork.ColoursRepository.Get(x => x.Id == id);

            if (colour == null)
            {
                return NotFound();
            }

            return Ok(colour);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {
            if (id != colour.Id)
            {
                return BadRequest();
            }

            _unitOfWork.ColoursRepository.Update(colour);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour colour)
        {
            await _unitOfWork.ColoursRepository.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: api/colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecolour(int id)
        {
            var colour = await _unitOfWork.ColoursRepository.Get(x => x.Id == id);
            if (colour == null)
            {
                return NotFound();
            }

            await _unitOfWork.ColoursRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColourExists(int id)
        {
            var colour = await _unitOfWork.ColoursRepository.Get(x => x.Id == id);
            return colour == null;
        }
    }
}
