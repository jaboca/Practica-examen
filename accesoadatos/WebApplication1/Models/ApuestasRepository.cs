using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class ApuestasRepository
	{
		private MySqlConnection Connect()
		{
			string connect = "Server=127.0.0.1;Port=3306;Database=casa_apuestas;UID=root;password=";
			MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connect);
			return conn;
		}
		internal Apuestas Retrieve()
		{
			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "Select * from Apuesta";
			conn.Open();
			MySqlDataReader res = command.ExecuteReader();
			Apuestas a = null;
			if (res.Read())
			{
				a = new Apuestas(res.GetInt32(0), res.GetString(1), res.GetDecimal(2), res.GetDecimal(3), res.GetInt32(4), res.GetInt32(5));
			}
			conn.Close();
			return a;
		}

		internal ApuestasDTO RetrieveDTO()
		{
			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "Select(A.cuota_apuesta,A.tipo,A.dinero_apuesta,U.Email,M.tipo_mercado) from Apuesta A INNER JOIN Usuarios U INNER JOIN Mercado M ON A.ID_MERCADO = M.id AND A.ID_USUARIOS = U.ID; ";
			conn.Open();
			MySqlDataReader res = command.ExecuteReader();
			ApuestasDTO a = null;
			if (res.Read())
			{
				a = new ApuestasDTO(res.GetString(0), res.GetDecimal(1), res.GetDecimal(2));
			}
			conn.Close();
			return a;
		}

		internal void Save(Apuestas a)
		{

			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "insert into Apuesta(Id,tipo,cuota_apuesta,dinero_apuesta,ID_MERCADO,ID_USUARIOS) values ('" + a.Id + "', '" + a.tipo + "', " + a.cuota_apuesta + "," + a.dinero_apuesta + "," + a.idApuesta + "," + a.ID_MERCADO + "," + a.ID_USUARIOS + " );";
			Debug.WriteLine("comando " + command.CommandText);

			Mercados m;
			double cuota_over;
			double cuota_under;
			double prob_over;
			double prob_under;

			prob_over = m.Mercado_dineroover / (m.Mercado_dineroover + m.Mercado_dinerounder);
			prob_under = m.Mercado_dinerounder / (m.Mercado_dineroover + m.Mercado_dinerounder);

			cuota_over = 1 / prob_over * 0.95;
			cuota_under = 1 / prob_under * 0.95;
			if (a.tipo == "over")
			{
				command.CommandText = "UPDATE Mercado set Mercado_dineroover =Mercado_dineroover" + a.dinero_apuesta + "WHERE id=" + a.ID_MERCADO + ";";
				Debug.WriteLine("comando " + command.CommandText);
			}
			else if (a.tipo == "under")
			{
				command.CommandText = "UPDATE Mercado set Mercado_dinerounder =Mercado_dinerounder" + a.dinero_apuesta + "WHERE id=" + a.ID_MERCADO + ";";
				Debug.WriteLine("comando " + command.CommandText);
			}

			try
			{
				conn.Open();
				command.ExecuteNonQuery();
				conn.Close();
			}
			catch (MySqlException e)
			{
				Debug.WriteLine("se ha producido un error de conexión");
			}
		}
	}
}