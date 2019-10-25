using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Mercados
	{
		public Mercados(string tipo_mercado, decimal Mercado_cuotaover, decimal Mercado_cuotaunder, int id, float Mercado_dineroover, float Mercado_dinerounder, int IDEvento)
		{
			this.tipo_mercado = tipo_mercado;
			this.Mercado_cuotaover = Mercado_cuotaover;
			this.Mercado_cuotaunder = Mercado_cuotaunder;
			this.id = id;
			this.Mercado_dineroover = Mercado_dineroover;
			this.Mercado_dinerounder = Mercado_dinerounder;
			this.IDEvento = IDEvento;
		}

		public int idMercado { get; set; }
		public int idEvento { get; set; }
		public string tipoApuesta { get; set; }
		public float dinero_over_under { get; set; }
		public string tipo_mercado { get; set; }
		public string over_under { get; set; }
		public string cuota_over_under { get; set; }
	}

	public class MercadosDTO
	{
		public MercadosDTO( string tipo_mercado, string cuota_over_under)
		{
			this.tipo_mercado = tipo_mercado;
			this.cuota_over_under = cuota_over_under;
		}

		public string tipo_mercado { get; set; }
		public string cuota_over_under { get; set; }
	}
}