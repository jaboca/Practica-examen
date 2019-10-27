using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Apuestas
	{
		public Apuestas(int Id,string tipo,decimal cuota_apuesta, decimal dinero_apuesta, int ID_MERCADO,int ID_USUARIOS)
		{
			this.Id = Id;
			this.tipo = tipo;
			this.cuota_apuesta = cuota_apuesta;
			this.dinero_apuesta = dinero_apuesta;
			this.ID_MERCADO = ID_MERCADO;
			this.ID_USUARIOS = ID_USUARIOS;
		}

		public int Id { get; set; }
		public string tipo { get; set; }
		public decimal cuota_apuesta { get; set; }
		public decimal dinero_apuesta { get; set; }
		public int idApuesta { get; set; }
		public int ID_MERCADO { get; set; }
		public int ID_USUARIOS { get; set; }
	}

	public class ApuestasDTO
	{
		public ApuestasDTO(string tipo,  decimal cuota_apuesta,  decimal dinero_apuesta)
		{
			this.tipo = tipo;
			this.cuota_apuesta = cuota_apuesta;
			this.dinero_apuesta = dinero_apuesta;
		}

		public string tipo { get; set; }
		public decimal cuota_apuesta { get; set; }
		public decimal dinero_apuesta { get; set; }
	}

}