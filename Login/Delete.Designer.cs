
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
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
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(38, 211);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(83, 50);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(19, 32);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsuarios.TabIndex = 12;
            // 
            // Delete
            // 
            this.AcceptButton = this.buttonEliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 271);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delete";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelUsuario;
		private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
	}