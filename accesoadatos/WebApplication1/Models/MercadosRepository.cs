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
			string connect = "Server=127.0.0.1;Port=3306;Database=Acceso a datos;UID=root;password=";
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
				m = new Mercados(m.GetInt(1), m.GetInt(2), m.GetString(3), m.GetFloat(4), m.GetString(5), m.GetString(6), m.GetString(7));
			}
			conn.Close();
			return m;
		}
	}
}