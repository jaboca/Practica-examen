using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class MercadosRepository
	{
		private MySqlConnection Connect()
		{
			string connect = "Server=127.0.0.1;Port=3306;Database=casa_apuestas;UID=root;password=";
			MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connect);
			return conn;
		}
		internal Mercados Retrieve()
		{
			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "Select * from Mercado";
			conn.Open();
			MySqlDataReader res = command.ExecuteReader();
			Mercados m = null;
			if (res.Read())
			{
				m = new Mercados(res.GetInt32(4), res.GetInt32(3), res.GetString(6), res.GetFloat(5), res.GetString(1), res.GetString(0), res.GetString(2));
			}
			conn.Close();
			return m;
		}
	}
}