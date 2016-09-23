using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    /// <summary>
    /// Dialogo para agregar un usuario determinado
    /// </summary>
    public partial class Agregar : Form
    {
        bool mAcepto = false;
        /// <summary>
        /// Inicializa una nueva instancia de la clase Agregar
        /// </summary>
        public Agregar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Muestra el dialogo de Agregar
        /// </summary>
        /// <returns>Devuelve los resultados ingresados en el dialogo</returns>
        public Login.ResultadosVentanas Mostrar()
        {
            Login.ResultadosVentanas Resultado = new Login.ResultadosVentanas();
            this.ShowDialog();
            Resultado.PresionoAceptar = mAcepto;
            mAcepto = false;
            Resultado.Usuario = textBoxUsuario.Text;
            Resultado.Contraseña = "";
            Resultado.NuevaContraseña = textBoxContraseña.Text;
            Resultado.RepetirNuevaContraseña = textBoxRepetirNuevaContraseña.Text;
            return Resultado;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            mAcepto = true;
            this.Close();
        }
    }