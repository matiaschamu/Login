using System;

    /// <summary>
    /// Configuracion de Login
    /// </summary>
    [Serializable()]
    public class Configuracion :   BibliotecaMaf.Clases.ConfiguracionBase.ConfiguracionBase
    {
        /// <summary>
        /// Lista de usuarios registrados
        /// </summary>
        public string[] Usuarios = null;
        /// <summary>
        /// Lista de contraseñas registradas
        /// </summary>
        public string[] Contraseñas = null;
        /// <summary>
        /// Inicializa una instancia de la clase configuracion
        /// </summary>
        public Configuracion()
            : base(null)
        {
        }
        /// <summary>
        ///  Inicializa una instancia de la clase configuracion
        /// </summary>
        /// <param name="FilePath">Path del archivo de configuracion</param>
        /// <param name="Encriptar">si el TRUE encripta el archivo de configuracion</param>
        public Configuracion(string FilePath, bool Encriptar)
            : base( FilePath,"","", Encriptar)
        {
            //Inicializo las variables.
            Usuarios = new string[0];
            Contraseñas = new string[0];
        }
    }