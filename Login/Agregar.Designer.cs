
	partial class Agregar
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelUsuario = new System.Windows.Forms.Label();
			this.labelContraseña = new System.Windows.Forms.Label();
			this.textBoxContraseña = new System.Windows.Forms.TextBox();
			this.textBoxUsuario = new System.Windows.Forms.TextBox();
			this.buttonCrear = new System.Windows.Forms.Button();
			this.textBoxRepetirNuevaContraseña = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BibliotecaMaf.Controles.Security.Properties.Resources.user2;
			this.pictureBox1.Location = new System.Drawing.Point(162, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(228, 249);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// labelUsuario
			// 
			this.labelUsuario.AutoSize = true;
			this.labelUsuario.Location = new System.Drawing.Point(58, 17);
			this.labelUsuario.Name = "labelUsuario";
			this.labelUsuario.Size = new System.Drawing.Size(43, 13);
			this.labelUsuario.TabIndex = 2;
			this.labelUsuario.Text = "Usuario";
			// 
			// labelContraseña
			// 
			this.labelContraseña.AutoSize = true;
			this.labelContraseña.Location = new System.Drawing.Point(49, 56);
			this.labelContraseña.Name = "labelContraseña";
			this.labelContraseña.Size = new System.Drawing.Size(61, 13);
			this.labelContraseña.TabIndex = 4;
			this.labelContraseña.Text = "Contraseña";
			// 
			// textBoxContraseña
			// 
			this.textBoxContraseña.Location = new System.Drawing.Point(19, 72);
			this.textBoxContraseña.Name = "textBoxContraseña";
			this.textBoxContraseña.PasswordChar = '*';
			this.textBoxContraseña.Size = new System.Drawing.Size(121, 20);
			this.textBoxContraseña.TabIndex = 1;
			this.textBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxUsuario
			// 
			this.textBoxUsuario.Location = new System.Drawing.Point(19, 33);
			this.textBoxUsuario.Name = "textBoxUsuario";
			this.textBoxUsuario.Size = new System.Drawing.Size(121, 20);
			this.textBoxUsuario.TabIndex = 0;
			this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonCrear
			// 
			this.buttonCrear.Location = new System.Drawing.Point(38, 211);
			this.buttonCrear.Name = "buttonCrear";
			this.buttonCrear.Size = new System.Drawing.Size(83, 50);
			this.buttonCrear.TabIndex = 3;
			this.buttonCrear.Text = "Crear";
			this.buttonCrear.UseVisualStyleBackColor = true;
			this.buttonCrear.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// textBoxRepetirNuevaContraseña
			// 
			this.textBoxRepetirNuevaContraseña.Location = new System.Drawing.Point(19, 111);
			this.textBoxRepetirNuevaContraseña.Name = "textBoxRepetirNuevaContraseña";
			this.textBoxRepetirNuevaContraseña.PasswordChar = '*';
			this.textBoxRepetirNuevaContraseña.Size = new System.Drawing.Size(121, 20);
			this.textBoxRepetirNuevaContraseña.TabIndex = 2;
			this.textBoxRepetirNuevaContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Repetir Nueva Contraseña";
			// 
			// Agregar
			// 
			this.AcceptButton = this.buttonCrear;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 271);
			this.Controls.Add(this.textBoxRepetirNuevaContraseña);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonCrear);
			this.Controls.Add(this.textBoxUsuario);
			this.Controls.Add(this.textBoxContraseña);
			this.Controls.Add(this.labelContraseña);
			this.Controls.Add(this.labelUsuario);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Agregar";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Agregar Usuario";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelUsuario;
		private System.Windows.Forms.Label labelContraseña;
		private System.Windows.Forms.TextBox textBoxContraseña;
		private System.Windows.Forms.TextBox textBoxUsuario;
		private System.Windows.Forms.Button buttonCrear;
		private System.Windows.Forms.TextBox textBoxRepetirNuevaContraseña;
		private System.Windows.Forms.Label label2;
	}