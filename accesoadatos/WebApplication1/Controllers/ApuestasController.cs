using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuestas
		[Authorize]
        public ApuestasDTO Get(string Email)
        {
			var repo = new ApuestasRepository();
			//Apuestas a = repo.Retrieve();
			ApuestasDTO a = repo.RetrieveDTO();
			return a;
		}

        // GET: api/Apuestas/5
        public Apuestas Get(int id)
        {
			var repo = new ApuestasRepository();
			Apuestas a = repo.Retrieve();
			return a;
        }

        // POST: api/Apuestas
        public void Post([FromBody]Apuestas d)
        {
			var repo = new ApuestasRepository();
			repo.Save(d);
		}

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
