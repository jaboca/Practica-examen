using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Eventos
	{
		public Eventos(int id, string equipo_local, string visitante)
		{
			this.id = id;
			this.equipo_local = equipo_local;
			this.visitante = visitante;
		}

		public int id { get; set; }
		public string equipo_local { get; set; }
		public string visitante { get; set; }
	}

	public class EventosDTO
	{
		public EventosDTO( string equipo_local, string visitante)
		{
			this.equipo_local = equipo_local;
			this.visitante = visitante;
		}

		public string equipo_local { get; set; }
		public string visitante { get; set; }

	}
}