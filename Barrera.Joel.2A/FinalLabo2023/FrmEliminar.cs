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
	public partial class FrmEliminar : FrmModificar
	{
		private Planeta planeta;

		public FrmEliminar(Planeta planeta)
		{
			InitializeComponent();
			this.planeta = planeta;
			base.SetearDatos(planeta);
			this.BloquearControles();
		}

		private void BloquearControles()
		{
			base.txtId.Enabled = false;
			base.txtNombre.Enabled = false;
			base.txtMasa.Enabled = false;
			base.txtDiametro.Enabled = false;
			base.txtSatelites.Enabled = false;
		}

		protected override void btnAceptar_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Desea eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Planetario p = new Planetario();
				if(p.Eliminar(this.planeta))
				{
					MessageBox.Show("Planeta eliminado", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("El planeta no fue eliminado", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
