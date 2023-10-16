namespace FinalLabo2023
{
	partial class FrmAgregar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnAceptar = new Button();
			btnCancelar = new Button();
			label1 = new Label();
			txtId = new TextBox();
			txtNombre = new TextBox();
			label2 = new Label();
			txtMasa = new TextBox();
			label3 = new Label();
			txtDiametro = new TextBox();
			label4 = new Label();
			txtSatelites = new TextBox();
			label5 = new Label();
			SuspendLayout();
			// 
			// btnAceptar
			// 
			btnAceptar.Location = new Point(125, 458);
			btnAceptar.Name = "btnAceptar";
			btnAceptar.Size = new Size(112, 34);
			btnAceptar.TabIndex = 0;
			btnAceptar.Text = "ACEPTAR";
			btnAceptar.UseVisualStyleBackColor = true;
			btnAceptar.Click += btnAceptar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(282, 458);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(112, 34);
			btnCancelar.TabIndex = 1;
			btnCancelar.Text = "CANCELAR";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(125, 116);
			label1.Name = "label1";
			label1.Size = new Size(30, 25);
			label1.TabIndex = 2;
			label1.Text = "ID";
			// 
			// txtId
			// 
			txtId.Location = new Point(244, 116);
			txtId.Name = "txtId";
			txtId.Size = new Size(150, 31);
			txtId.TabIndex = 3;
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(244, 172);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(150, 31);
			txtNombre.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(125, 172);
			label2.Name = "label2";
			label2.Size = new Size(85, 25);
			label2.TabIndex = 4;
			label2.Text = "NOMBRE";
			// 
			// txtMasa
			// 
			txtMasa.Location = new Point(244, 230);
			txtMasa.Name = "txtMasa";
			txtMasa.Size = new Size(150, 31);
			txtMasa.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(125, 230);
			label3.Name = "label3";
			label3.Size = new Size(62, 25);
			label3.TabIndex = 6;
			label3.Text = "MASA";
			// 
			// txtDiametro
			// 
			txtDiametro.Location = new Point(244, 289);
			txtDiametro.Name = "txtDiametro";
			txtDiametro.Size = new Size(150, 31);
			txtDiametro.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(125, 289);
			label4.Name = "label4";
			label4.Size = new Size(101, 25);
			label4.TabIndex = 8;
			label4.Text = "DIAMETRO";
			// 
			// txtSatelites
			// 
			txtSatelites.Location = new Point(244, 345);
			txtSatelites.Name = "txtSatelites";
			txtSatelites.Size = new Size(150, 31);
			txtSatelites.TabIndex = 11;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(125, 345);
			label5.Name = "label5";
			label5.Size = new Size(92, 25);
			label5.TabIndex = 10;
			label5.Text = "SATELITES";
			// 
			// FrmAgregar
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(541, 609);
			Controls.Add(txtSatelites);
			Controls.Add(label5);
			Controls.Add(txtDiametro);
			Controls.Add(label4);
			Controls.Add(txtMasa);
			Controls.Add(label3);
			Controls.Add(txtNombre);
			Controls.Add(label2);
			Controls.Add(txtId);
			Controls.Add(label1);
			Controls.Add(btnCancelar);
			Controls.Add(btnAceptar);
			Name = "FrmAgregar";
			Text = "FrmAgregar";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAceptar;
		private Button btnCancelar;
		private Label label1;
		protected TextBox txtId;
		protected TextBox txtNombre;
		private Label label2;
		protected TextBox txtMasa;
		private Label label3;
		protected TextBox txtDiametro;
		private Label label4;
		protected TextBox txtSatelites;
		private Label label5;
	}
}