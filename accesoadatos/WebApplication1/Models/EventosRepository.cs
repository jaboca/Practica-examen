using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class EventosRepository
	{
		private MySqlConnection Connect()
		{
			string connect = "Server=127.0.0.1;Port=3306;Database=casa_apuestas;UID=root;password=";
			MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connect);
			return conn;
		}
		internal Eventos RetrieveMercado()
		{
			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "Select(m.tipo_mercado,m.Mercado_cuotaover,m.Mercado_cuotaunder)  from Mercado m";
			conn.Open();
			MySqlDataReader res = command.ExecuteReader();
			Eventos e = null;
			if (res.Read())
			{
				e = new Eventos(res.GetInt32(0), res.GetString(1), res.GetString(2));
			}
			conn.Close();
			return e;
		}

		internal EventosDTO RetrieveDTO()
		{
			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "Select * from Evento";
			conn.Open();
			MySqlDataReader res = command.ExecuteReader();
			EventosDTO e = null;
			if (res.Read())
			{
				e = new EventosDTO (res.GetString(0), res.GetString(1));
			}
			conn.Close();
			return e;
		}
	}
}