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
		public string tipo_mercado { get; set; }
		public decimal Mercado_cuotaover { get; set; }
		public decimal Mercado_cuotaunder { get; set; }
		public int id { get; set; }
		public float Mercado_dineroover { get; set; }
		public float Mercado_dinerounder { get; set; }
		public int IDEvento { get; set; }
	}

	public class MercadosDTO
	{
		public MercadosDTO( string tipo_mercado, decimal Mercado_cuotaover, decimal Mercado_cuotaunder)
		{
			this.tipo_mercado = tipo_mercado;
			this.Mercado_cuotaover = Mercado_cuotaover;
			this.Mercado_cuotaunder = Mercado_cuotaunder;

		}

		public string tipo_mercado { get; set; }
		public decimal Mercado_cuotaover { get; set; }
		public decimal Mercado_cuotaunder { get; set; }

	}
}