using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    /// <summary>
    /// Dialogo para iniciar sesion con un usuario determinado
    /// </summary>
	public partial class Access : Form
	{
        bool mAcepto = false;
        /// <summary>
        /// Inicializa una nueva instancia de la clase Access
        /// </summary>
		public Access()
		{
			InitializeComponent();
		}
        /// <summary>
        /// Muestra el dialogo de access
        /// </summary>
        /// <returns>Retorna los datos ingresados en el formulario</returns>
		public Login.ResultadosVentanas Mostrar()
		{
			Login.ResultadosVentanas Resultado = new Login.ResultadosVentanas();
			this.ShowDialog();
            Resultado.PresionoAceptar = mAcepto;
            mAcepto = false;
			Resultado.Usuario = textBoxUsuario.Text;
			Resultado.Contraseña = textBoxContraseña.Text;
			return Resultado;
		}

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            mAcepto = true;
            this.Close();
        }
	}
