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
			string connect = "Server=127.0.0.1;Port=3306;Database=Acceso a datos;UID=root;password=";
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
				a = new Apuestas( a.GetString(1), a.GetString(2), a.GetString(3), a.GetDecimal(4), a.GetDecimal(5), a.GetDecimal(6), a.GetDecimal(7), a.GetString(8), a.GetInt(9));
			}
			conn.Close();
			return a;
		}
	}
}