using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CineplexService.Models;

namespace CineplexService.Controllers
{
    public class CineplexController : ApiController
    {
        private CineplexServiceContext db = new CineplexServiceContext();

        // GET: api/Cineplex
        public IQueryable<Movie30022962> GetMovie30022962()
        {
            return db.Movie30022962;
        }

        // GET: api/Cineplex/5
        [ResponseType(typeof(Movie30022962))]
        public IHttpActionResult GetMovie30022962(int id)
        {
            Movie30022962 movie30022962 = db.Movie30022962.Find(id);
            if (movie30022962 == null)
            {
                return NotFound();
            }

            return Ok(movie30022962);
        }

        // PUT: api/Cineplex/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMovie30022962(int id, Movie30022962 movie30022962)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movie30022962.MovieId)
            {
                return BadRequest();
            }

            db.Entry(movie30022962).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie30022962Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cineplex
        [ResponseType(typeof(Movie30022962))]
        public IHttpActionResult PostMovie30022962(Movie30022962 movie30022962)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movie30022962.Add(movie30022962);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = movie30022962.MovieId }, movie30022962);
        }

        // DELETE: api/Cineplex/5
        [ResponseType(typeof(Movie30022962))]
        public IHttpActionResult DeleteMovie30022962(int id)
        {
            Movie30022962 movie30022962 = db.Movie30022962.Find(id);
            if (movie30022962 == null)
            {
                return NotFound();
            }

            db.Movie30022962.Remove(movie30022962);
            db.SaveChanges();

            return Ok(movie30022962);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Movie30022962Exists(int id)
        {
            return db.Movie30022962.Count(e => e.MovieId == id) > 0;
        }
    }
}