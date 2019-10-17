using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Apuestas
	{
		public Apuestas(string tipo, string tipo_apuesta, string over, decimal cuota_apuesta, decimal cuota_over_under, decimal dinero_apuesta, decimal dinero_over_under, string nombreusuario, int idApuesta)
		{
			this.tipo = tipo;
			this.tipo_apuesta = tipo_apuesta;
			this.over = over;
			this.cuota_apuesta = cuota_apuesta;
			this.cuota_over_under = cuota_over_under;
			this.dinero_apuesta = dinero_apuesta;
			this.dinero_over_under = dinero_over_under;
			this.nombreusuario = nombreusuario;
			this.idApuesta = idApuesta;
		}

		public string tipo { get; set; }
		public string tipo_apuesta { get; set; }
		public string over { get; set; }
		public decimal cuota_apuesta { get; set; }
		public decimal cuota_over_under { get; set; }
		public decimal dinero_apuesta { get; set; }
		public decimal dinero_over_under { get; set; }
		public string nombreusuario { get; set; }
		public int idApuesta { get; set; }
	}

	public class ApuestasDTO
	{
		public ApuestasDTO(string tipo, string tipo_apuesta,  decimal cuota_apuesta,  decimal dinero_apuesta, string nombreusuario)
		{
			this.tipo = tipo;
			this.tipo_apuesta = tipo_apuesta;
			this.cuota_apuesta = cuota_apuesta;
			this.dinero_apuesta = dinero_apuesta;
			this.nombreusuario = nombreusuario;
		}

		public string tipo { get; set; }
		public string tipo_apuesta { get; set; }
		public decimal cuota_apuesta { get; set; }
		public decimal dinero_apuesta { get; set; }
		public string nombreusuario { get; set; }
	}

}