using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Entidades
{
	public class Planeta : Astro
	{
		private int satelites;

		public Planeta() : base (){ }
		public Planeta(int id, string nombre, double masa, double diametro) : base(id, nombre, masa, diametro) { }
		public Planeta(int id, string nombre, double masa, double diametro, int satelites) : this(id, nombre, masa, diametro)
		{
			this.satelites = satelites;
		}

		[JsonInclude]
		public int Satelites
		{ 
			get { return this.satelites; }
			set { this.satelites = value; }
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
			sb.AppendLine($"Satelites: {this.satelites}");

			return sb.ToString();
		}
	}
}
