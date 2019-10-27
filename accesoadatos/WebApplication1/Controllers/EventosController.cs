using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public EventosDTO Get()
        {
			var repo = new EventosRepository();
			//Eventos e = repo.Retrieve();
			EventosDTO e = repo.RetrieveDTO();
			return e;
		}

        // GET: api/Eventos/5
        public Eventos Get(int id)
        {
			var repo = new EventosRepository();
			Eventos e = repo.RetrieveMercado();
			return e;

        }

        // POST: api/Eventos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
