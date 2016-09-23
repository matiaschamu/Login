
	partial class Login
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerBloqueo = new System.Windows.Forms.Timer();
            this.groupBoxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPrincipal.Controls.Add(this.label1);
            this.groupBoxPrincipal.Enabled = false;
            this.groupBoxPrincipal.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(145, 92);
            this.groupBoxPrincipal.TabIndex = 0;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Si quiere puede usar \r\neste contenedor para \r\nponer los componentes \r\nprotegidos " +
    "por contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBloqueo
            // 
            this.timerBloqueo.Tick += new System.EventHandler(this.timerBloqueo_Tick);
            // 
            // Login
            // 
            this.Controls.Add(this.groupBoxPrincipal);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(145, 92);
            this.groupBoxPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxPrincipal;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerBloqueo;
	}
