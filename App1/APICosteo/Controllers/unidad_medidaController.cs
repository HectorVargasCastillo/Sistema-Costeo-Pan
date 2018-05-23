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
    public class unidad_medidaController : ApiController
    {
        private Database1Entities db = new Database1Entities();

        // GET: api/unidad_medida
        public IQueryable<unidad_medida> Getunidad_medida()
        {
            return db.unidad_medida;
        }

        // GET: api/unidad_medida/5
        [ResponseType(typeof(unidad_medida))]
        public IHttpActionResult Getunidad_medida(int id)
        {
            unidad_medida unidad_medida = db.unidad_medida.Find(id);
            if (unidad_medida == null)
            {
                return NotFound();
            }

            return Ok(unidad_medida);
        }

        // PUT: api/unidad_medida/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putunidad_medida(int id, unidad_medida unidad_medida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != unidad_medida.Id)
            {
                return BadRequest();
            }

            db.Entry(unidad_medida).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!unidad_medidaExists(id))
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

        // POST: api/unidad_medida
        [ResponseType(typeof(unidad_medida))]
        public IHttpActionResult Postunidad_medida(unidad_medida unidad_medida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.unidad_medida.Add(unidad_medida);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = unidad_medida.Id }, unidad_medida);
        }

        // DELETE: api/unidad_medida/5
        [ResponseType(typeof(unidad_medida))]
        public IHttpActionResult Deleteunidad_medida(int id)
        {
            unidad_medida unidad_medida = db.unidad_medida.Find(id);
            if (unidad_medida == null)
            {
                return NotFound();
            }

            db.unidad_medida.Remove(unidad_medida);
            db.SaveChanges();

            return Ok(unidad_medida);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool unidad_medidaExists(int id)
        {
            return db.unidad_medida.Count(e => e.Id == id) > 0;
        }
    }
}