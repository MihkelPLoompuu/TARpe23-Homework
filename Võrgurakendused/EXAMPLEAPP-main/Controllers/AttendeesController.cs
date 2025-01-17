using ITB2203Application.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ITB2203Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly DataContext _context;

        public AttendeesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Attendee>> GetAttendees(string? name = null, string? email = null)
        {
            var query = _context.Attendees!.AsQueryable();

            if (name != null)
                query = query.Where(x => x.Name != null && x.Name.ToUpper().Contains(name.ToUpper()));
            if (email != null)
                query = query.Where(x => x.Email != null && x.Email.ToUpper().Contains(email.ToUpper()));

            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<TextReader> GetAttendee(int id)
        {
            var test = _context.Attendees!.Find(id);
            if (test == null)
            {
                return NotFound();
            }

            return Ok(test);
        }

        [HttpPut("{id}")]
        public IActionResult PutAttendee(int id, Attendee test)
        {
            var dbTest = _context.Attendees!.AsNoTracking().FirstOrDefault(x => x.Id == test.Id);
            if (id != test.Id || dbTest == null)
            {
                return NotFound();
            }

            _context.Update(test);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult<Attendee> PostAttendee(Attendee test)
        {
            var dbExercise = _context.Attendees!.Find(test.Id);
            var ev = _context.Events!.Find(test.EventId);
            var query = _context.Attendees!.AsQueryable();
            if (ev == null) 
            {
                return NotFound();
            }
            var sp = _context.Speakers!.Find(ev.SpeakerId);
            if (!test.Email.Contains('@'))
            {
                return BadRequest();
            }
            if (test.RegistrationTime > ev.Date)
            {
                return BadRequest();
            }
            if(test.Email == sp.Email)
            {
                return BadRequest();
            }
            query = query.Where(x => x.Email == test.Email);
            if (query.Count() > 0)
            {
                return BadRequest();
            }
            if (dbExercise == null)
            {
                _context.Add(test);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetAttendee), new { Id = test.Id }, test);
            }
            else
            {
                return Conflict();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAttendee(int id)
        {
            var test = _context.Attendees!.Find(id);
            if (test == null)
            {
                return NotFound();
            }

            _context.Remove(test);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
