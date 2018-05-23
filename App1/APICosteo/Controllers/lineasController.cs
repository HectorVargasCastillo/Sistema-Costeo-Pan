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
using APICosteo;

namespace APICosteo.Controllers
{
    public class lineasController : ApiController
    {
        private Database1Entities db = new Database1Entities();

        // GET: api/lineas
        public IQueryable<linea> Getlineas()
        {
            return db.lineas;
        }

        // GET: api/lineas/5
        [ResponseType(typeof(linea))]
        public IHttpActionResult Getlinea(int id)
        {
            linea linea = db.lineas.Find(id);
            if (linea == null)
            {
                return NotFound();
            }

            return Ok(linea);
        }

        // PUT: api/lineas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putlinea(int id, linea linea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != linea.id)
            {
                return BadRequest();
            }

            db.Entry(linea).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!lineaExists(id))
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

        // POST: api/lineas
        [ResponseType(typeof(linea))]
        public IHttpActionResult Postlinea(linea linea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.lineas.Add(linea);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = linea.id }, linea);
        }

        // DELETE: api/lineas/5
        [ResponseType(typeof(linea))]
        public IHttpActionResult Deletelinea(int id)
        {
            linea linea = db.lineas.Find(id);
            if (linea == null)
            {
                return NotFound();
            }

            db.lineas.Remove(linea);
            db.SaveChanges();

            return Ok(linea);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool lineaExists(int id)
        {
            return db.lineas.Count(e => e.id == id) > 0;
        }
    }
}