using EIS.BLL;
using EIS.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EIS.API.Controllers
{
    public class QuoteController : ApiController
    {
        QuoteBs quoteObjBs;

        public QuoteController()
        {
            quoteObjBs = new QuoteBs();
        }

        [ResponseType(typeof(IEnumerable<Role>))]
        public IHttpActionResult Get()
        {
            return Ok(quoteObjBs.GetALL());
        }

        // GET api/<controller>/5
        [ResponseType(typeof(Quote))]
        public IHttpActionResult Get(int id)
        {
            Quote quote = quoteObjBs.GetByID(id);
            if (quote != null)
                return Ok(quote);
            else
                return NotFound();
        }

        // POST api/<controller>
        [ResponseType(typeof(Quote))]
        public IHttpActionResult Post(Quote quote)
        {
            if (ModelState.IsValid)
            {
                quoteObjBs.Insert(quote);
                return CreatedAtRoute("DefaultApi", new { id = quote.QuoteId }, quote);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [ResponseType(typeof(Quote))]
        public IHttpActionResult Put(int id, Quote quote)
        {
            if (ModelState.IsValid)
            {
                quoteObjBs.Update(quote);
                return Ok(quote);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // DELETE api/<controller>/5
        [ResponseType(typeof(Quote))]
        public IHttpActionResult Delete(int id)
        {
            Quote quote = quoteObjBs.GetByID(id);
            if (quote != null)
            {
                quoteObjBs.Delete(id);
                return Ok(quote);
            }
            else
            {
                return NotFound();
            }
        }
    }
}