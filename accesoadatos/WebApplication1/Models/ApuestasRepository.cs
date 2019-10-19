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
				a = new Apuestas( res.GetString(0), res.GetString(1), res.GetString(2), res.GetDecimal(3), res.GetDecimal(4), res.GetDecimal(5), res.GetDecimal(6), res.GetString(7), res.GetInt32(8));
			}
			conn.Close();
			return a;
		}

		internal ApuestasDTO RetrieveDTO()
		{
			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "Select * from Apuesta";
			conn.Open();
			MySqlDataReader res = command.ExecuteReader();
			ApuestasDTO a = null;
			if (res.Read())
			{
				a = new ApuestasDTO(res.GetString(0), res.GetString(1), res.GetDecimal(2), res.GetDecimal(3), res.GetString(4));
			}
			conn.Close();
			return a;
		}

		internal void Save(Apuestas a)
		{

			MySqlConnection conn = Connect();
			MySqlCommand command = conn.CreateCommand();
			command.CommandText = "insert into Apuesta(nombreusuario,tipo_mercado,tipo_apuesta,cuota,dinero_apuesta) values ('" + a.nombreusuario + "', '" + a.tipo + "','" + a.tipo_apuesta + "', " + a.cuota_apuesta + "," + a.dinero_apuesta + " );";
			Debug.WriteLine("comando " + command.CommandText);

            if (a.tipo == "over")
            {
                command.CommandText = "UPDATE Mercado set dinero_apuesta =Dinero_apuesta"+ a.dinero_apuesta + "WHERE id="+ a.idApuesta +";";
                Debug.WriteLine("comando " + command.CommandText);
            }
            else if (a.tipo == "under")
            {
                command.CommandText = "UPDATE Mercado set dinero_apuesta =Dinero_apuesta" + a.dinero_apuesta + "WHERE id=" + a.idApuesta + ";";
				Debug.WriteLine("comando " + command.CommandText);
            }

			try
			{
				conn.Open();
				command.ExecuteNonQuery();
				conn.Close();
			}
			catch(MySqlException e)
			{
				Debug.WriteLine("se ha producido un error de conexión");
			}
		}
	}
}