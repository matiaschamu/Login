using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    /// <summary>
    /// Dialogo para editar un usuario determinado
    /// </summary>
	public partial class Edit : Form
	{
        bool mEliminarUsuario = false;
        bool mAcepto = false;
        /// <summary>
        /// Inicializa una nueva instancia de la clase Edit
        /// </summary>
		public Edit()
		{
			InitializeComponent();
		}
        /// <summary>
        /// Muestra el dialogo de edicion
        /// </summary>
        /// <param name="Datos">Datos pasados al dialogo para cargar sus propios controles</param>
        /// <returns>Retorna los datos ingresados en el formulario</returns>
		public Login.ResultadosVentanas Mostrar(Login.ResultadosVentanas Datos)
		{
            textBoxUsuario.Text = Datos.Usuario;
			Login.ResultadosVentanas Resultado = new Login.ResultadosVentanas();
			this.ShowDialog();
            Resultado.PresionoAceptar = mAcepto;
            mAcepto = false;
			Resultado.Usuario = textBoxUsuario.Text;
			Resultado.Contraseña = textBoxContraseña.Text;
            Resultado.NuevaContraseña = textBoxNuevaContraseña .Text;
            Resultado.RepetirNuevaContraseña = textBoxRepetirNuevaContraseña.Text;
            Resultado.EliminarUsuario = mEliminarUsuario;
			return Resultado;
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
            mAcepto = true;
			this.Close();
		}

        private void linkLabelEliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Para eliminar al usuario: " + textBoxUsuario.Text + " ingrese la contraseña", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (System.Windows.Forms.MessageBox.Show("Desea eliminar de forma permanente al usuario: " + textBoxUsuario.Text, "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    mEliminarUsuario = true;
                    mAcepto = true;
                    this.Close();
                }
            }
        }
	}
