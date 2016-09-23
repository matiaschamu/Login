using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    /// <summary>
    /// Dialogo para eliminar un usuario predeterminado
    /// </summary>
	public partial class Delete : Form
	{
        bool mEliminarUsuario = false;
        bool mAcepto = false;
        /// <summary>
        /// Inicializa una nueva instancia de la clase Delete
        /// </summary>
        public Delete()
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
            if (Datos.Usuarios.Length > 0)
            {
                foreach (string User in Datos.Usuarios)
                {
                    comboBoxUsuarios.Items.Add(User);
                    if (User == Datos.Usuario)
                    {
                        comboBoxUsuarios.SelectedIndex = comboBoxUsuarios.Items.Count - 1;
                    }
                }
            }


            //comboBoxUsuarios.Text = Datos.Usuario;
			Login.ResultadosVentanas Resultado = new Login.ResultadosVentanas();
			this.ShowDialog();
            Resultado.PresionoAceptar = mAcepto;
            mAcepto = false;
			Resultado.Usuario = comboBoxUsuarios.Text;
			Resultado.Contraseña = textBoxContraseña.Text;
            Resultado.EliminarUsuario = mEliminarUsuario;
			return Resultado;
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
            mEliminarUsuario = true;
            mAcepto = true;
			this.Close();
		}
	}