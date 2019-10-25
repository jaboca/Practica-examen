using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Eventos
	{
		public Eventos(int id, string visitante, string equipo_local)
		{
			this.id = id;
			this.visitante = visitante;
			this.equipo_local = equipo_local;
		}

		public int id { get; set; }
		public string visitante { get; set; }
		public string equipo_local { get; set; }
	}

	public class EventosDTO
	{
		public EventosDTO( string equipo_local, string visitante)
		{
			this.visitante = visitante;
			this.equipo_local = equipo_local;
		}

		public string visitante { get; set; }
		public string equipo_local { get; set; }

	}
}