using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Apuestas
	{
		public Apuestas(int Id,string tipo,decimal cuota_apuesta, decimal dinero_apuesta, int ID_MERCADO)
		{
			this.Id = Id;
			this.tipo = tipo;
			this.cuota_apuesta = cuota_apuesta;
			this.dinero_apuesta = dinero_apuesta;
			this.ID_MERCADO = ID_MERCADO;
		}

		public string tipo { get; set; }
		public decimal cuota_apuesta { get; set; }
		public decimal dinero_apuesta { get; set; }
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