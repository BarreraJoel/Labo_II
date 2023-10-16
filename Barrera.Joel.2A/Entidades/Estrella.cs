using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entidades
{
	public class Estrella : Astro
	{
		private int tipoEspectro;

		public Estrella() : base(){ }
		public Estrella(int id, string nombre, double masa, double diametro) : base(id, nombre, masa, diametro) { }
		public Estrella(int id, string nombre, double masa, double diametro, int tipoEspectro) : this(id, nombre, masa, diametro)
		{
			this.tipoEspectro = tipoEspectro;
		}

		public int TipoEspectro
		{
			get { return this.tipoEspectro; }
			set { this.tipoEspectro = value; }
		}

		protected override string InformacionAstro()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"ID: {base.id}");
			sb.AppendLine($"Nombre: {base.nombre}");
			sb.AppendLine($"Masa: {base.masa}");
			sb.AppendLine($"Diametro: {base.diametro}");

			return sb.ToString();
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(this.InformacionAstro());
			sb.AppendLine($"Tipo Espectro: {this.tipoEspectro}");

			return sb.ToString();
		}
	}
}
