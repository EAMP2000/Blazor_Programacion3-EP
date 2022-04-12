using Datos.Interfacez;
using Datos.Repositorios;
using Modelos;
using Proyecto3_Blazor.Data;
using Proyecto3_Blazor.Interfacez; 

namespace Proyecto3_Blazor.Servicios
{
    public class UsuarioServicios : IUsuarioServicio
    {
        private readonly MySQLConfiguracion _configuracion;
        private IUsuarioRepositorio usuarioRepositorio;

        public UsuarioServicios(MySQLConfiguracion configuracion)
        {
            _configuracion = configuracion;
            usuarioRepositorio = new UsuarioRepositorio(configuracion.CadenaConexion);
        }

        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public  async Task<IEnumerable<Usuario>> GetLista()
        {
            return await usuarioRepositorio.GetLista();
        }

        public Task<Usuario> GetPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
