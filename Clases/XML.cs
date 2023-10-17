using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
	public class JSON
	{
		private string path;

		public Serializador()
		{
			//this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\astros.xml";
			//this.path = @"./astros.xml";
		}

		public bool Serializar(List<Astro> lista)
		{
			bool serializado = false;

			try
			{
				using (StreamWriter sw = new StreamWriter(this.path))
				{
					XmlSerializer xml = new XmlSerializer(typeof(List<Astro>));
					xml.Serialize(sw, lista);
				}
				serializado = true;
			}
			catch (Exception)
			{
				serializado = false;
			}

			return serializado;
		}

		public List<Astro>? Deserializar()
		{
			List<Astro>? lista = new List<Astro>();
			try
			{
				using (StreamReader reader = new StreamReader(this.path))
				{
					XmlSerializer xml = new XmlSerializer(typeof(List<Astro>));
					lista = (List<Astro>)xml.Deserialize(reader);
				}
			}
			catch (Exception)
			{
				lista = null;
			}

			return lista;
		}

	}
}
