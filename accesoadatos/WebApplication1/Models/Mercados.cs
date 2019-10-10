using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Mercados
	{
		public Mercados(int idMercado, int idEvento, string tipoApuesta, float dinero_over_under, string tipo_mercado, string over_under, string cuota_over_under)
		{
			this.idMercado = idMercado;
			this.idEvento = idEvento;
			this.tipoApuesta = tipoApuesta;
			this.dinero_over_under = dinero_over_under;
			this.tipo_mercado = tipo_mercado;
			this.over_under = over_under;
			this.cuota_over_under = cuota_over_under;
		}

		public int idMercado { get; set; }
		public int idEvento { get; set; }
		public string tipoApuesta { get; set; }
		public float dinero_over_under { get; set; }
		public string tipo_mercado { get; set; }
		public string over_under { get; set; }
		public string cuota_over_under { get; set; }
	}
}