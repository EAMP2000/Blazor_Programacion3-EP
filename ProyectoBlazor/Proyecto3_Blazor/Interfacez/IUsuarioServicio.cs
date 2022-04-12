using Modelos;

namespace Proyecto3_Blazor.Interfacez
{
    public interface IUsuarioServicio
    {
        //misma interfaz de la capeta Interfaces de el proycto Datos
        Task<bool> Nuevo(Usuario usuario);

        Task<bool> Actualizar(Usuario usuario);

        Task<bool> Eliminar(Usuario usuario);

        Task<IEnumerable<Usuario>> GetLista();

        Task<Usuario> GetPorCodigo(string codigo);
    }
}
