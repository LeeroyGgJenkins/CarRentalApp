using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApp.Server.Data;
using CarRentalApp.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CarRentalApp.Server.IRepository;
using Microsoft.VisualBasic.FileIO;

namespace CarRentalApp.Server.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        /*OLD
        private readonly ApplicationDbContext _context;
        public MakesController(ApplicationDbContext context)
        {
            _context = context;
        } */
        //New
        private readonly IUnitOfWork _unitOfWork;
        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var makes = await _unitOfWork.MakesRepository.GetAll();
            return Ok(makes);
        }

        // GET: Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            var make = await _unitOfWork.MakesRepository.Get(x => x.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitOfWork.MakesRepository.Update(make);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id)) 
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

        // POST: Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            await _unitOfWork.MakesRepository.Insert(make);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitOfWork.MakesRepository.Get(x => x.Id == id);
            if (make == null)
            {
                return NotFound();
            }

            await _unitOfWork.MakesRepository.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var make = await _unitOfWork.MakesRepository.Get(x => x.Id == id);
            return make == null;
        }
    }
}
