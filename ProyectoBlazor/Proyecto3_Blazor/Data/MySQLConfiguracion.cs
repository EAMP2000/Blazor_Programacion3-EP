namespace Proyecto3_Blazor.Data
{   //su objetivo es poder capturar la cadena de conexion y mandarla a el proyecto Datos

    public class MySQLConfiguracion
    {
        public string CadenaConexion { get; }

        public MySQLConfiguracion(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }
    }
}
