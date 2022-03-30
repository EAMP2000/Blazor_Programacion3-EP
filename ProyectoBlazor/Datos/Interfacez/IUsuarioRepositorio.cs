using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfacez
{
    public interface IUsuarioRepositorio
    {
        //metodos para los Usuarios (Metodos Asincronos)
        Task<bool> Nuevo(Usuario usuario);

        Task<bool> Actualizar(Usuario usuario);

        Task<bool> Eliminar(Usuario usuario);

        Task<IEnumerable<Usuario>> GetLista();

        Task<Usuario> GetPorCodigo(string codigo);
    }
}
