using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Models;
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
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalDtos);
        }

        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            var movie = _context.Movies.Single(m => m.Id == rentalDto.MovieId);
            if (movie == null)
                return BadRequest("Invalid MovieId.");

            if (movie.NumberAvailable < 1)
                return BadRequest("Movie is not currently available.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == rentalDto.CustomerId);
            if (customer == null)
                return BadRequest("Invalid CustomerId.");

            movie.NumberAvailable--;

            var rental = Mapper.Map<RentalDto, Rental>(rentalDto);
            rental.Customer = customer;
            rental.Movie = movie;

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
