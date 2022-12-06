using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Metodos
{
	 class Conexion
	{	//Metodo de la conexion
		public static MySqlConnection conexion()
		{
			//Manejando errores
            try
			{
				//Comando de la informacion de la base de datos
				string cadenaConexion = "server = bhc6gfahks5l73k7sjji-mysql.services.clever-cloud.com; port = 3306; user id = ucxp5xnej4vzjkyg; password = 4i8qScnb5BLhRzt9O6yS; database = bhc6gfahks5l73k7sjji;";
				//Haciendo conexion
				MySqlConnection conex = new MySqlConnection(cadenaConexion);
				//Regresando variable de la conexion
				return conex;
            }          
			catch (MySqlException ex)
			{	//Error en dado caso no conecte
				MessageBox.Show("Error al conectar con la base de datos" + ex.Message);
				//Regresamos valor nulo
				return null;
			}
		}
	}
}