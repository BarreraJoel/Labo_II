using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
	public class ADO
	{
		private SqlConnection conexion;
		private string tabla;

		public ADO(string base_de_datos, string tabla)
		{
			this.tabla = tabla;
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.DataSource = ".";
			builder.InitialCatalog = base_de_datos;
			builder.IntegratedSecurity = false;
			builder.UserID = "sa";
			builder.Password = "alumno";

			this.conexion = new SqlConnection(builder.ConnectionString);
		}

		private void CerrarConexion()
		{
			if(this.conexion.State == ConnectionState.Open)
			{
				this.conexion.Close();
			}
		}

		public List<Astro> ObtenerTodos()
		{
			List<Astro> lista = new List<Astro>();
			string query = $"SELECT * FROM {this.tabla}";

			try
			{
				this.conexion.Open();
				using (SqlCommand comando = new SqlCommand(query, this.conexion))
				{
					using (SqlDataReader lector = comando.ExecuteReader())
					{
						while (lector.Read())
						{
							/*int id = lector.GetInt32(0);
							string nombre = lector.GetString(1);
							double masa = lector.GetDouble(2);
							double diametro = lector.GetDouble(3);
							int satelites = lector.GetInt32(4);

							Planeta p = new Planeta(id, nombre, masa, diametro, satelites);
							lista.Add(p);*/
						}
					}
				}
			}
			catch (Exception)
			{
				lista = new List<Astro>();
			}
			finally
			{
				this.CerrarConexion();
			}

			return lista;
		}

		public Planeta? ObtenerUno(int id)
		{
			Planeta? p = null;
			
			try
			{
				string query = $"SELECT * FROM {this.tabla} WHERE id = @id";
				
				SqlCommand comando = new SqlCommand();
	            comando.Parameters.AddWithValue("@id", id);
				comando.CommandText = query;
                comando.Connection = this.conexion;

				this.conexion.Open();

				using (SqlDataReader lector = comando.ExecuteReader())
				{
					while (lector.Read())
					{
						int idPlaneta = lector.GetInt32(0);
						string nombre = lector.GetString(1);
						double masa = lector.GetDouble(2);
						double diametro = lector.GetDouble(3);
						int satelites = lector.GetInt32(4);

						p = new Planeta(idPlaneta, nombre, masa, diametro, satelites);
					}
				}
			}
			catch (Exception)
			{
				p = null;
			}
			finally
			{
				this.CerrarConexion();
			}

			return p;
		}

		public bool Agregar(object obj)
		{
			bool agregado = false;
			string query = $"INSERT INTO {this.tabla} () VALUES (@)";
			
			try
			{
				using (SqlCommand comando = new SqlCommand(query, this.conexion))
				{
					//comando.Parameters.AddWithValue("@id", p.ID);

					this.conexion.Open();

					int filas = comando.ExecuteNonQuery();
					if(filas > 0)
					{
						agregado = true;
					}
				}
			}
			catch (Exception)
			{
				agregado = false;
			}
			finally
			{
				this.CerrarConexion();
			}

			return agregado;
		}

		public bool Modificar(object obj)
		{
			bool modificado = false;
			string query = $"UPDATE {this.tabla} SET id = @id WHERE id = @id";

			try
			{
				using (SqlCommand comando = new SqlCommand(query, this.conexion))
				{
	            	//comando.Parameters.AddWithValue("@id", p.ID);

					this.conexion.Open();

					int filas = comando.ExecuteNonQuery();
					if (filas > 0)
					{
						modificado = true;
					}
				}
			}
			catch (Exception)
			{
				modificado = false;
			}
			finally
			{
				this.CerrarConexion();
			}

			return modificado;
		}

		public bool Eliminar(object obj)
		{
			bool eliminado = false;
			
			try
			{
				string query = $"DELETE FROM {this.tabla} WHERE id = @id";
				
				using(SqlCommand comando = new SqlCommand(query, this.conexion))
				{
	            	//comando.Parameters.AddWithValue("@id", p.ID);
					this.conexion.Open();

					int filas = comando.ExecuteNonQuery();
					if (filas > 0)
					{
						eliminado = true;
					}
				}
			}
			catch (Exception)
			{
				eliminado = false;
			}
			finally
			{
				this.CerrarConexion();
			}

			return eliminado;
		}
	}
}
