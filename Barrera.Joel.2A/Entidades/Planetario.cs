using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
	public class Planetario
	{
		private ADO ado;

		public Planetario()
		{
			this.ado = new ADO("FinalLabo2", "planetas");
		}

		public List<Astro> ObtenerTodos()
		{
			return this.ado.ObtenerTodos();
		}

		public bool Agregar(Planeta p)
		{
			return this.ado.Agregar(p);
		}

		public bool Modificar(Planeta p)
		{
			return this.ado.Modificar(p);
		}

		public bool Eliminar(Planeta p)
		{
			return this.ado.Eliminar(p);
		}
	}
}
