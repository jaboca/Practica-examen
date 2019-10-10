using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
				a = new Apuestas( res.GetString(0), res.GetString(1), res.GetString(2), res.GetDecimal(3), res.GetDecimal(4), res.GetDecimal(5), res.GetDecimal(6), res.GetString(7), res.GetInt32(8));
			}
			conn.Close();
			return a;
		}
	}
}