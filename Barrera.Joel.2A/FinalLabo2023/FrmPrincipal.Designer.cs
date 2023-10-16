namespace FinalLabo2023
{
	partial class FrmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnObtenerTodos = new Button();
			btnSerializar = new Button();
			btnDeserializar = new Button();
			btnAgregar = new Button();
			btnEliminar = new Button();
			btnModificar = new Button();
			btnTask = new Button();
			dataGridView1 = new DataGridView();
			lstb = new ListBox();
			btnCancelarTask = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnObtenerTodos
			// 
			btnObtenerTodos.Location = new Point(55, 109);
			btnObtenerTodos.Name = "btnObtenerTodos";
			btnObtenerTodos.Size = new Size(188, 67);
			btnObtenerTodos.TabIndex = 0;
			btnObtenerTodos.Text = "OBTENER TODOS";
			btnObtenerTodos.UseVisualStyleBackColor = true;
			btnObtenerTodos.Click += btnObtenerTodos_Click;
			// 
			// btnSerializar
			// 
			btnSerializar.Location = new Point(55, 302);
			btnSerializar.Name = "btnSerializar";
			btnSerializar.Size = new Size(188, 67);
			btnSerializar.TabIndex = 1;
			btnSerializar.Text = "SERIALIZAR";
			btnSerializar.UseVisualStyleBackColor = true;
			btnSerializar.Click += btnSerializar_Click;
			// 
			// btnDeserializar
			// 
			btnDeserializar.Location = new Point(55, 375);
			btnDeserializar.Name = "btnDeserializar";
			btnDeserializar.Size = new Size(188, 67);
			btnDeserializar.TabIndex = 2;
			btnDeserializar.Text = "DESERIALIZAR";
			btnDeserializar.UseVisualStyleBackColor = true;
			btnDeserializar.Click += btnDeserializar_Click;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(933, 30);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(188, 67);
			btnAgregar.TabIndex = 3;
			btnAgregar.Text = "AGREGAR";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.Location = new Point(933, 191);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(188, 67);
			btnEliminar.TabIndex = 4;
			btnEliminar.Text = "ELIMINAR";
			btnEliminar.UseVisualStyleBackColor = true;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// btnModificar
			// 
			btnModificar.Location = new Point(933, 109);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(188, 67);
			btnModificar.TabIndex = 5;
			btnModificar.Text = "MODIFICAR";
			btnModificar.UseVisualStyleBackColor = true;
			btnModificar.Click += btnModificar_Click;
			// 
			// btnTask
			// 
			btnTask.Location = new Point(933, 302);
			btnTask.Name = "btnTask";
			btnTask.Size = new Size(188, 67);
			btnTask.TabIndex = 6;
			btnTask.Text = "LANZAR TASK";
			btnTask.UseVisualStyleBackColor = true;
			btnTask.Click += btnTask_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(295, 30);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 33;
			dataGridView1.Size = new Size(600, 239);
			dataGridView1.TabIndex = 7;
			// 
			// lstb
			// 
			lstb.FormattingEnabled = true;
			lstb.ItemHeight = 25;
			lstb.Location = new Point(295, 375);
			lstb.Name = "lstb";
			lstb.Size = new Size(600, 179);
			lstb.TabIndex = 8;
			// 
			// btnCancelarTask
			// 
			btnCancelarTask.Location = new Point(933, 375);
			btnCancelarTask.Name = "btnCancelarTask";
			btnCancelarTask.Size = new Size(188, 67);
			btnCancelarTask.TabIndex = 9;
			btnCancelarTask.Text = "CANCELAR TASK";
			btnCancelarTask.UseVisualStyleBackColor = true;
			btnCancelarTask.Click += btnCancelarTask_Click;
			// 
			// FrmPrincipal
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1208, 666);
			Controls.Add(btnCancelarTask);
			Controls.Add(lstb);
			Controls.Add(dataGridView1);
			Controls.Add(btnTask);
			Controls.Add(btnModificar);
			Controls.Add(btnEliminar);
			Controls.Add(btnAgregar);
			Controls.Add(btnDeserializar);
			Controls.Add(btnSerializar);
			Controls.Add(btnObtenerTodos);
			Name = "FrmPrincipal";
			Text = "Form1";
			Load += FrmPrincipal_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnObtenerTodos;
		private Button btnSerializar;
		private Button btnDeserializar;
		private Button btnAgregar;
		private Button btnEliminar;
		private Button btnModificar;
		private Button btnTask;
		private DataGridView dataGridView1;
		private ListBox lstb;
		private Button btnCancelarTask;
	}
}