using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Xml.Serialization;
//using System.Xml;
using Newtonsoft.Json;

namespace Entidades
{
	public class Serializador : ISerializada<Astro>
	{
		private string path;

		public Serializador()
		{
			this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\astros.json";
			//this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\astros.xml";
		}

		public bool Serializar(List<Astro> lista)
		{
			bool serializado = false;

			try
			{
				using (StreamWriter sw = new StreamWriter(this.path))
				{
					JsonSerializerSettings sett = new JsonSerializerSettings
					{
						TypeNameHandling = TypeNameHandling.All
					};
					string json = JsonConvert.SerializeObject(lista, Formatting.Indented, sett);
					sw.Write(json);
					serializado = true;
				}

				/*using (StreamWriter sw = new StreamWriter(this.path))
				{
					XmlSerializer xml = new XmlSerializer(typeof(List<Astro>));
					xml.Serialize(sw, lista);
				}
				serializado = true;*/
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
				using (StreamReader sr = new StreamReader(this.path))
				{
					string json = sr.ReadToEnd();
					JsonSerializerSettings sett = new JsonSerializerSettings
					{
						TypeNameHandling = TypeNameHandling.All
					};
					lista = JsonConvert.DeserializeObject<List<Astro>>(json, sett);
				}

				/*using (StreamReader sr = new StreamReader(this.path))
				{
					XmlSerializer xml = new XmlSerializer(typeof(List<Astro>));
					lista = (List<Astro>)xml.Deserialize(sr);
				}*/
			}
			catch (Exception)
			{
				lista = null;
			}

			return lista;
		}

	}
}
