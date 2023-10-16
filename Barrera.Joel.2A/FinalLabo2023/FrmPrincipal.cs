using Entidades;

namespace FinalLabo2023
{
	public partial class FrmPrincipal : Form
	{
		private Planetario planetario;
		private CancellationToken cancellationToken;
		private CancellationTokenSource cancellationTokenSource;
		
		public FrmPrincipal()
		{
			InitializeComponent();
			this.planetario = new Planetario();
			this.cancellationTokenSource = new CancellationTokenSource();
			this.cancellationToken = this.cancellationTokenSource.Token;
			this.Click += this.eventoCancelado;
		}

		private Planeta? BuscarPlaneta(int id)
		{
			Planetario pla = new Planetario();
			Planeta? planeta = null;

			foreach (Planeta p in pla.ObtenerTodos())
			{
				if (p.ID == id)
				{
					planeta = p;
					break;
				}
			}

			return planeta;
		}

		private void MostrarPlaneta(List<Astro> astros)
		{
			List<Planeta> p = new List<Planeta>();
			foreach (Astro astro in astros)
			{
				if (astro is Planeta)
				{
					p.Add((Planeta)astro);
				}
			}
			this.dataGridView1.DataSource = p;
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{

		}

		//Base de datos
		private void btnObtenerTodos_Click(object sender, EventArgs e)
		{
			Planetario planetario = new Planetario();
			this.MostrarPlaneta(planetario.ObtenerTodos());
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmAgregar agregar = new FrmAgregar();
			agregar.delegadoMostrador = this.MostrarPlaneta;
			agregar.ShowDialog();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count == 1)
			{
				int id = (int)this.dataGridView1.SelectedRows[0].Cells["ID"].Value;
				FrmModificar modificar = new FrmModificar(this.BuscarPlaneta(id));
				modificar.delegadoMostrador = this.MostrarPlaneta;
				modificar.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe elegir un planeta para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count == 1)
			{
				int id = (int)this.dataGridView1.SelectedRows[0].Cells["ID"].Value;
				FrmEliminar eliminar = new FrmEliminar(this.BuscarPlaneta(id));
				eliminar.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe elegir un planeta para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Serializacion
		private void btnSerializar_Click(object sender, EventArgs e)
		{
			Serializador ser = new Serializador();
			List<Astro> astros = new List<Astro>();

			foreach (Astro astro in this.planetario.ObtenerTodos())
			{
				if (astro is Planeta)
				{
					astros.Add((Planeta)astro);
					MessageBox.Show(((Planeta)astro).ToString(), astro.GetType().ToString());
				}
			}
			astros.Add(new Estrella(41, "Sol", 123, 4123, 5));

			if (ser.Serializar(astros))
			{
				MessageBox.Show("Serializado correctamente", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No se serializó", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDeserializar_Click(object sender, EventArgs e)
		{
			Serializador ser = new Serializador();
			List<Astro>? lista = ser.Deserializar();
			if (lista != null)
			{
				foreach (Astro astro in lista)
				{
					MessageBox.Show(astro.ToString(), astro.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Fallo la deserializacion", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void MostrarTarea()
		{
			MessageBox.Show("Tarea", "Exito");
		}

		//Task
		private bool Metodo() { return true; }
		private void btnTask_Click(object sender, EventArgs e)
		{
			Func<bool> f = new Func<bool>(this.Metodo);
			Task.Run(() =>
			{
				for (int i = 0; i < 5; i++)
				{
					Thread.Sleep(3000);
					if(!this.cancellationToken.IsCancellationRequested)
					{
						this.lstb.Items.Add(i);
					}
				}
			});
		}

		private void btnCancelarTask_Click(object sender, EventArgs e)
		{
			this.cancellationTokenSource.Cancel();
		}

		//Eventos
		private void eventoCancelado(object sender, EventArgs e)
		{
			MessageBox.Show("Evento Click", "Click");
		}
	}
}