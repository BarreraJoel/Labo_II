using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
	public class Tarea
	{
		/*
			Creamos la Task y la corremos:
				Task.Run(Metodo (action));

			Necesitamos: 
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				CancellationToken cancellationToken = cancellationTokenSource.Token;

			Para cancelar:
				cancellationTokenSource.Cancel();

			Pregunto si se solicito la cancelacion dentro del metodo que corre la Task:
				if(!cancellationToken.IsCancellationRequested)
				{
					//codigo
				}
		*/
	}

	public class Extensora
	{
		/*
			public static void Extendido(this object obj)
			{
				//codigo
			}
		*/
	}

	public class Eventos
	{
		/*
			public delegate void Mostrador(Hora hora, HoraEventArgs e);
			public event Mostrador HoraMostrada;

			Se puede crear un EventArgs propio.
			Ejemplo :
				public class HoraEventArgs : EventArgs
				{
					public Hora Hora { get; set };

					public HoraEventArgs(Hora hora)
					{
						this.Hora = hora;
					}
				}

			Sumar metodo a un evento:
				textBox.Click += metodo;

			Invocar metodo del evento
				HoraMostrada.Invoke(datos, new HoraEventArgs(hora));
		*/
	}

	public class Formus
	{
		/*
			private void SetearLabel(Label label, string texto)
			{
				if (label.InvokeRequired)
				{
					Delegate delegado = this.SetearLabel;
					object[] args = { label, texto };
					label.BeginInvoke(delegado, args);
				}
				else
				{
					label.Text = texto;
				}
			}
		*/
	}
}
