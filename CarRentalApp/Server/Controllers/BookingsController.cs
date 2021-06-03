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
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: Bookings
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _unitOfWork.BookingsRepository.GetAll();
            return Ok(bookings);
        }

        // GET: Bookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var booking = await _unitOfWork.BookingsRepository.Get(x => x.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        // PUT: Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.BookingsRepository.Update(booking);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
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

        // POST: Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            await _unitOfWork.BookingsRepository.Insert(booking);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var booking = await _unitOfWork.BookingsRepository.Get(x => x.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            await _unitOfWork.BookingsRepository.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        //THIS RETURNS AN ERROR
        private async Task<bool> BookingExists(int id)
        {
            var booking = await _unitOfWork.BookingsRepository.Get(x => x.Id == id);
            return booking == null;
        }
    }
}
