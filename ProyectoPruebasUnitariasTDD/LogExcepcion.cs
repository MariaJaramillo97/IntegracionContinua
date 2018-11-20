using System;

namespace ProyectoPruebasUnitariasTDD
{
    public class LogExcepcion : IDisposable
    {

        #region Propiedades
        /// <summary>
        /// Evento o Acción que se está ejecutando
        /// </summary>
        public string Evento { get; set; }
        /// <summary>
        /// Nombre del archivo recibido o procesado
        /// </summary>
        public string NomArchivo { get; set; }
        /// <summary>
        /// Consulta o procedimiento almacenado
        /// </summary>       
        public string Query { get; set; }
        /// <summary>
        /// Parametros de la consulta o procedimiento almacenado
        /// </summary>      
        public string ParametrosQuery { get; set; }
        /// <summary>
        /// Mensaje de la excepción
        /// </summary>      
        public string MensajeExcepcion { get; set; }
        /// <summary>
        /// Tipo de Excepción
        /// </summary>
        public string TipoExcepcion { get; set; }
        /// <summary>
        /// Detalle o Traza de Excepción
        /// </summary>
        public string TrazaExcepcion { get; set; }
        /// <summary>
        /// URL donde se presenta la excepcion. 
        /// </summary>
        public string ExceptionURL { get; set; }
        /// <summary>
        /// Usuario logueado. 
        /// </summary>
        public string UserLogin { get; set; }
        /// <summary>
        /// Nombre del servidor donde se realiza la peticion
        /// </summary>
        public string NombreServidor { get; set; }
        /// <summary>
        /// Direccion IP del cliente
        /// </summary>      
        public string DireccionIP { get; set; }
        /// <summary>
        /// Direccion IP del cliente
        /// </summary>
        public string Navegador { get; set; }
        public bool ExisteExcepcion { get; set; }
        public int CodigoError { get; set; }

        #endregion
        #region Constructores
        public LogExcepcion()
        {
        }

        public LogExcepcion(string sEvento, string sTipoExcepcion, string sTraza)
        {
            Evento = sEvento;
            TipoExcepcion = sTipoExcepcion;
            TrazaExcepcion = sTraza;
        }

        public LogExcepcion(string sEvento, string sTipoExcepcion, string sTraza, string sUrl, string sClienteIP,
                            string sNavegador, string sNombreObjetoBD, string sParametrosBD, int iCodigoErrorBD, string sUsuarioRed)
        {
            Evento = sEvento;
            Query = sNombreObjetoBD;
            ParametrosQuery = sParametrosBD;
            TipoExcepcion = sTipoExcepcion;
            TrazaExcepcion = sTraza;
            ExceptionURL = sUrl;
            DireccionIP = sClienteIP;
            Navegador = sNavegador;
            CodigoError = iCodigoErrorBD;
            UserLogin = sUsuarioRed;
        }

        public LogExcepcion(string sEvento, string sQuery, string sParametros, string sMensajeExcepcion,
                            string sTipoExcepcion, string sTrazaExcecion)
        {
            Evento = sEvento;
            Query = sQuery;
            ParametrosQuery = sParametros;
            MensajeExcepcion = sMensajeExcepcion;
            TipoExcepcion = sTipoExcepcion;
            TrazaExcepcion = sTrazaExcecion;
            ExisteExcepcion = true;
            CodigoError = -1;
        }

        #endregion
        // Destructor
        ~LogExcepcion()
        {
            // In case the client forgets to call
            // Dispose , destructor will be invoked for
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Free managed objects.
            }
            // Free unmanaged objects

        }
        public void Dispose()
        {
            Dispose(true);
            // Ensure that the destructor is not called
            GC.SuppressFinalize(this);
        }

    }
}