using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Entidades
{
	public class JSON
	{
		private string path;

		public Serializador()
		{
			this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\astros.json";
			//this.path = @"./astros.json";
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
			}
			catch (Exception)
			{
				lista = null;
			}

			return lista;
		}

	}
}
