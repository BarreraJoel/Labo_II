using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FinalLabo2023
{
	public partial class FrmAgregar : Form
	{
		public delegate void MostradorPlaneta(List<Astro> planetas);
		public MostradorPlaneta delegadoMostrador;

		public FrmAgregar()
		{
			InitializeComponent();
		}

		protected bool VerificarControles()
		{
			bool valido = false;

			foreach (Control control in this.Controls)
			{
				if(control is TextBox)
				{
					valido = ((TextBox)control).Text != "";
				}
				if(!valido)
				{
					break;
				}
			}

			return valido;
		}

		protected Planeta CrearPlaneta()
		{
			int id = int.Parse(this.txtId.Text);
			string nombre = this.txtNombre.Text;
			double masa = double.Parse(this.txtMasa.Text);
			double diametro = double.Parse(this.txtDiametro.Text);
			int satelites = int.Parse(this.txtSatelites.Text);

			return new Planeta(id, nombre, masa, diametro, satelites);
		}

		protected virtual void btnAceptar_Click(object sender, EventArgs e)
		{
			if(this.VerificarControles())
			{
				Planetario planetario = new Planetario();
				Planeta p = this.CrearPlaneta();
				if(planetario.Agregar(p))
				{
					this.delegadoMostrador(new List<Astro> { p });
					MessageBox.Show("Planeta agregado", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("No se pudo agregar el planeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
