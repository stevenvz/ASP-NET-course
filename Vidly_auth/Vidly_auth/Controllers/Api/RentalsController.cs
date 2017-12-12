using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly_auth.Dtos;
using Vidly_auth.Models;

namespace Vidly_auth.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/rentals
        public IHttpActionResult GetRentals()
        {
            var rentalDtos = _context.Rentals
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalDtos);
        }

        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var rental = Mapper.Map<RentalDto, Rental>(rentalDto);

            _context.Rentals.Add(rental);
            _context.SaveChanges();

            return Ok();
        }

        // PUT /api/rentals/id
        [HttpPut]
        public IHttpActionResult UpdateRental(int id, RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                return NotFound();

            Mapper.Map(rentalDto, rentalInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/rentals/id
        [HttpDelete]
        public IHttpActionResult DeleteRental(int id, RentalDto rentalDto)
        {
            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                return NotFound();

            _context.Rentals.Remove(rentalInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
