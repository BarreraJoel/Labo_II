using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLabo2023
{
	public partial class FrmModificar : FrmAgregar
	{
		private Planeta planeta;

		public FrmModificar()
		{
			InitializeComponent();
		}
		public FrmModificar(Planeta planeta) : this()
		{
			this.planeta = planeta;
			this.SetearDatos(planeta);
		}

		protected void SetearDatos(Planeta p)
		{
			base.txtId.Text = p.ID.ToString();
			base.txtNombre.Text = p.Nombre;
			base.txtMasa.Text = p.Masa.ToString();
			base.txtDiametro.Text = p.Diametro.ToString();
			base.txtSatelites.Text = p.Satelites.ToString();
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			if (base.VerificarControles())
			{
				Planetario planetario = new Planetario();
				Planeta p = base.CrearPlaneta();
				if (planetario.Modificar(p))
				{
					base.delegadoMostrador(new List<Astro> { p });
					MessageBox.Show("Planeta modificado", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("El planeta no fue modificado", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Debe completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
