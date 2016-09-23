using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BibliotecaMaf.Clases.ConfiguracionBase;

    /// <summary>
    /// Clase que permite administrar distintas cuentas de usuario y inicios de sesion con contraseña
    /// </summary>
    public partial class Login : UserControl
    {
        Configuracion ConfigLogin = new Configuracion(Application.StartupPath.ToString() + "\\Login.Dat", true);
        private string mContraseñaLogin = "";
        /// <summary>
        /// Valores devueltos por los dialogos de login
        /// </summary>
        public struct ResultadosVentanas
        {
            /// <summary>
            /// Nombre de usuario
            /// </summary>
            public string Usuario;
            /// <summary>
            /// Contraseña
            /// </summary>
            public string Contraseña;
            /// <summary>
            /// Contraseña por la que se va a cambiar la actual
            /// </summary>
            public string NuevaContraseña;
            /// <summary>
            /// Repeticion de la nueva contraseña
            /// </summary>
            public string RepetirNuevaContraseña;
            /// <summary>
            /// Pedido de eliminar el usuario
            /// </summary>
            public bool EliminarUsuario;
            /// <summary>
            /// Lista de todos los usuarios
            /// </summary>
            public string[] Usuarios;
            /// <summary>
            /// Se devuelve true cuando en algun dialogo se acepto la operacion
            /// </summary>
            public bool PresionoAceptar;
        }

        /// <summary>
        /// Evento de login
        /// </summary>
        /// <param name="sender">Objeto que hace la llamada</param>
        /// <param name="e">Parametros del evento</param>
        public delegate void EventHandler(object sender, System.EventArgs e);
        /// <summary>
        /// Se produce cuando se cierra la sesion
        /// </summary>
        public event EventHandler Bloqueo;
        /// <summary>
        /// Se produce cuando se inicia sesion
        /// </summary>
        public event EventHandler Desbloqueo;

        /// <summary>
        /// Inicializa una instancia de Login
        /// </summary>
        public Login()
        {
            InitializeComponent();
            ConfigLogin.Cargar();
        }
        /// <summary>
        /// Abre un dialogo para autenticarse con un usuario y contraseña
        /// </summary>
        public void IniciarSesion()
        {
            if (ConfigLogin.Usuarios.Length > 0)
            {
                Access F = new Access();
                ResultadosVentanas Resul = F.Mostrar();

                if (Resul.PresionoAceptar == true)
                {
                    bool mUsuarioExiste = false;
                    for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                    {
                        if (Resul.Usuario.ToUpper() == ConfigLogin.Usuarios[i].ToUpper())
                        {
                            mUsuarioExiste = true;
                            if (Resul.Contraseña == ConfigLogin.Contraseñas[i])
                            {

                                EstaBloqueado = false;
                                mNombreUsuarioLogin = Resul.Usuario;
                                mContraseñaLogin = Resul.Contraseña;
                                groupBoxPrincipal.Enabled = true;

                                if (Desbloqueo != null)
                                {
                                    Desbloqueo(this, new System.EventArgs());
                                }


                                if (mSegundosBloqueoAutomatico > 0)
                                {
                                    timerBloqueo.Interval = mSegundosBloqueoAutomatico * 1000;
                                    timerBloqueo.Start();
                                }
                                else
                                {
                                    timerBloqueo.Stop();
                                }
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (mUsuarioExiste == false)
                    {
                        if (Resul.Usuario != "")
                        {
                            System.Windows.Forms.MessageBox.Show("El nombre de usuario es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No hay usuarios registrados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Agregar F = new Agregar();
                ResultadosVentanas Resul = F.Mostrar();

                if (Resul.PresionoAceptar == true)
                {
                    if (Resul.Usuario == "")
                    {
                        System.Windows.Forms.MessageBox.Show("Debe ingresar un nombre de usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (Resul.NuevaContraseña != Resul.RepetirNuevaContraseña)
                    {
                        System.Windows.Forms.MessageBox.Show("Las contraseñas ingresadas no son iguales", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (ConfigLogin.Usuarios.Length > 0)
                    {
                        for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                        {
                            if (Resul.Usuario.ToUpper() == ConfigLogin.Usuarios[i].ToUpper())
                            {
                                System.Windows.Forms.MessageBox.Show("Este usuario ya existe, ingrese otro nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    Array.Resize(ref	ConfigLogin.Usuarios, ConfigLogin.Usuarios.Length + 1);
                    Array.Resize(ref	ConfigLogin.Contraseñas, ConfigLogin.Contraseñas.Length + 1);

                    ConfigLogin.Usuarios[ConfigLogin.Usuarios.Length - 1] = Resul.Usuario;
                    ConfigLogin.Contraseñas[ConfigLogin.Contraseñas.Length - 1] = Resul.NuevaContraseña;
                    ConfigLogin.Guardar();
                    System.Windows.Forms.MessageBox.Show("La cuenta fue creada con exito, ya puede ingresar con su nuevo nombre de usuario y contraseña", "Cuenta Creada con exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Cierra la sesion activa
        /// </summary>
        public void CerrarSesion()
        {
            if (Bloqueo != null)
            {
                Bloqueo(this, new System.EventArgs());
            }
            EstaBloqueado = true;
            mNombreUsuarioLogin = null;
            mContraseñaLogin = null;
            groupBoxPrincipal.Enabled = false;
        }

        private bool mEstaBloqueado = true;
        /// <summary>
        /// Determina si una sesion esta iniciada(desbloqueado) o finalizada(bloqueado)
        /// </summary>
        public bool EstaBloqueado
        {
            get
            {
                return mEstaBloqueado;
            }
            set
            {
                mEstaBloqueado = value;
            }
        }

        private string mNombreUsuarioLogin = "";
        /// <summary>
        /// Nombre del usuario que esta logueado actualmente
        /// </summary>
        public string NombreUsuarioLogin
        {
            get
            {
                return mNombreUsuarioLogin;
            }
        }

        private int mSegundosBloqueoAutomatico = 0;
        /// <summary>
        /// Segundos transcurridos despues de iniciar sesion para que ce cierre automaticamente, 0 es desactivado
        /// </summary>
        public int SegundosBloqueoAutomatico
        {
            get
            {
                return mSegundosBloqueoAutomatico;
            }
            set
            {
                if (value < 0)
                {
                    mSegundosBloqueoAutomatico = 0;
                    timerBloqueo.Stop();
                }
                else
                {
                    mSegundosBloqueoAutomatico = value;
                }
            }
        }

        private void timerBloqueo_Tick(object sender, EventArgs e)
        {
            CerrarSesion();
            timerBloqueo.Stop();
        }

        /// <summary>
        /// Abre un dialogo para eliminar un usuario registrado
        /// </summary>
        public void EliminarUsuario()
        {
            if (EstaBloqueado == false)
            {

                Delete F = new Delete();
                ResultadosVentanas Enviar = new ResultadosVentanas();
                Enviar.Usuario = NombreUsuarioLogin;
                Enviar.Usuarios = ConfigLogin.Usuarios;
                ResultadosVentanas Resul = F.Mostrar(Enviar);

                if (Resul.PresionoAceptar == true)
                {
                    if (Resul.EliminarUsuario == true)
                    {

                        if (Resul.Contraseña == mContraseñaLogin)
                        {

                            string[] Usuarios = new string[0];
                            string[] Contraseñas = new string[0];

                            for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                            {
                                if (Resul.Usuario.ToUpper() == ConfigLogin.Usuarios[i].ToUpper())
                                {

                                }
                                else
                                {
                                    Array.Resize(ref Usuarios, Usuarios.Length + 1);
                                    Array.Resize(ref Contraseñas, Contraseñas.Length + 1);
                                    Usuarios[Usuarios.Length - 1] = ConfigLogin.Usuarios[i];
                                    Contraseñas[Contraseñas.Length - 1] = ConfigLogin.Contraseñas[i];
                                }
                            }

                            ConfigLogin.Usuarios = Usuarios;
                            ConfigLogin.Contraseñas = Contraseñas;
                            ConfigLogin.Guardar();
                            CerrarSesion();
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("La contraseña no coincide con la de la cuenta que inicio sesion...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Abre un dialogo que permite editar el usuario actual
        /// </summary>
        public void EditarUsuario()
        {
            if (EstaBloqueado == false)
            {
                Edit F = new Edit();
                ResultadosVentanas Enviar = new ResultadosVentanas();
                Enviar.Usuario = NombreUsuarioLogin;
                ResultadosVentanas Resul = F.Mostrar(Enviar);

                if (Resul.PresionoAceptar == true)
                {
                    if (Resul.EliminarUsuario == true)
                    {
                        if (Resul.Usuario.ToUpper() == mNombreUsuarioLogin.ToUpper())
                        {
                            if (Resul.Contraseña == mContraseñaLogin)
                            {

                                string[] Usuarios = new string[0];
                                string[] Contraseñas = new string[0];

                                for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                                {
                                    if (Resul.Usuario.ToUpper() == ConfigLogin.Usuarios[i].ToUpper())
                                    {

                                    }
                                    else
                                    {
                                        Array.Resize(ref Usuarios, Usuarios.Length + 1);
                                        Array.Resize(ref Contraseñas, Contraseñas.Length + 1);
                                        Usuarios[Usuarios.Length - 1] = ConfigLogin.Usuarios[i];
                                        Contraseñas[Contraseñas.Length - 1] = ConfigLogin.Contraseñas[i];
                                    }
                                }

                                ConfigLogin.Usuarios = Usuarios;
                                ConfigLogin.Contraseñas = Contraseñas;
                                ConfigLogin.Guardar();
                                CerrarSesion();
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("La contraseña no coincide con la de la cuenta...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("El nombre de usuario no coincide con el de la cuenta...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        bool mCerrarSesion = false;
                        if ((Resul.Usuario != "") && (Resul.Usuario != mNombreUsuarioLogin))
                        {
                            if (Resul.Contraseña == mContraseñaLogin)
                            {
                                for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                                {
                                    if (ConfigLogin.Usuarios[i].ToUpper() == mNombreUsuarioLogin.ToUpper())
                                    {
                                        ConfigLogin.Usuarios[i] = Resul.Usuario;
                                        break;
                                    }
                                }
                                System.Windows.Forms.MessageBox.Show("El nombre de usuario: " + mNombreUsuarioLogin + ", se reemplazo por: " + Resul.Usuario + ", debido a que cambio el nombre de usuario si hubiera habido un cambio tambien en la contraseña este ultimo no tiene efecto, para cambiar la contraseña no modifique el nombre de usuario", "Cambio de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ConfigLogin.Guardar();
                                mNombreUsuarioLogin = Resul.Usuario;
                                mCerrarSesion = true;
                            }
                        }
                        else if ((Resul.Usuario != "") && (Resul.Usuario.ToUpper() == mNombreUsuarioLogin.ToUpper()))
                        {
                            if (Resul.Contraseña == mContraseñaLogin)
                            {
                                if (Resul.NuevaContraseña == Resul.RepetirNuevaContraseña)
                                {
                                    for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                                    {
                                        if (ConfigLogin.Usuarios[i].ToUpper() == mNombreUsuarioLogin.ToUpper())
                                        {
                                            ConfigLogin.Contraseñas[i] = Resul.NuevaContraseña;
                                            break;
                                        }
                                    }
                                    System.Windows.Forms.MessageBox.Show("La contraseña se cambio con exito", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ConfigLogin.Guardar();
                                    mContraseñaLogin = Resul.NuevaContraseña;
                                    mCerrarSesion = true;

                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show("Las contraseñas no son iguales", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Contraseña incorrecta", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("El cambio no fue aplicado", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (mCerrarSesion == true)
                        {
                            CerrarSesion();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Abre un dialogo para permitir agregar un usuario
        /// </summary>
        public void AgregarUsuario()
        {
            Agregar F = new Agregar();
            ResultadosVentanas Resul = F.Mostrar();


            if (Resul.PresionoAceptar == true)
            {
                if (Resul.NuevaContraseña != Resul.RepetirNuevaContraseña)
                {
                    System.Windows.Forms.MessageBox.Show("Las contraseñas ingresadas no son iguales", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Resul.Usuario.Trim() != "")
                {
                    if (ConfigLogin.Usuarios.Length > 0)
                    {
                        for (int i = 0; i < ConfigLogin.Usuarios.Length; i++)
                        {
                            if (Resul.Usuario.ToUpper() == ConfigLogin.Usuarios[i].ToUpper())
                            {
                                System.Windows.Forms.MessageBox.Show("Este usuario ya existe, ingrese otro nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    Array.Resize(ref	ConfigLogin.Usuarios, ConfigLogin.Usuarios.Length + 1);
                    Array.Resize(ref	ConfigLogin.Contraseñas, ConfigLogin.Contraseñas.Length + 1);

                    ConfigLogin.Usuarios[ConfigLogin.Usuarios.Length - 1] = Resul.Usuario;
                    ConfigLogin.Contraseñas[ConfigLogin.Contraseñas.Length - 1] = Resul.NuevaContraseña;
                    ConfigLogin.Guardar();
                    System.Windows.Forms.MessageBox.Show("La cuenta fue creada con exito, ya puede ingresar con su nuevo nombre de usuario y contraseña", "Cuenta Creada con exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
