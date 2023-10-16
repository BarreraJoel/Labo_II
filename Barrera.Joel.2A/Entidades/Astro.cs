using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Astro
	{
		protected int id;
		protected string nombre;
		protected double masa;
		protected double diametro;

		public Astro() { }
		public Astro(int id, string nombre, double masa, double diametro) : this()
		{
			this.id = id;
			this.nombre = nombre;
			this.masa = masa;
			this.diametro = diametro;
		}

		public int ID
		{
			get { return this.id; }
			set { this.id = value; }
		}
		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}
		public double Masa
		{
			get { return this.masa; }
			set { this.masa = value; }
		}
		public double Diametro
		{
			get { return this.diametro; }
			set { this.diametro = value; }
		}

		protected virtual string InformacionAstro()
		{
			return "";
		}
	}
}
