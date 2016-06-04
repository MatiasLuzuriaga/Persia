using System;
using MySql.Data.MySqlClient;

namespace Persia
{
	public class GestorConsultas
	{
		private MySqlConnection sqlconn;
		
		public GestorConsultas ()
		{
			new I18N.West.CP1250 ();
			string connsqlstring = "Server=localhost;Port=3306;database=persia;User Id=root;Password=;charset=utf8";
			sqlconn = new MySqlConnection(connsqlstring);

		}

		public void CrearUsuario(string idFacebook, string nombre, string apellido)
		{
			sqlconn.Open();
			string queryString = "Insert INTO usuario(idfacebook, nombre, apellido) VALUES('" + idFacebook + "','" + nombre +"','" + apellido +"')";
			MySqlCommand sqlcmd = new MySqlCommand(queryString, sqlconn);
			sqlcmd.ExecuteScalar();
			sqlconn.Close();
		}

		public void CrearPublicacion(string titulo, string descripcion)
		{
			sqlconn.Open();
			string queryString = "Insert INTO publicacion(titulo, descripcion) VALUES('" + titulo +"','" + descripcion +"')";
			MySqlCommand sqlcmd = new MySqlCommand(queryString, sqlconn);
			sqlcmd.ExecuteScalar();
			sqlconn.Close();
		}
			

	}
}

