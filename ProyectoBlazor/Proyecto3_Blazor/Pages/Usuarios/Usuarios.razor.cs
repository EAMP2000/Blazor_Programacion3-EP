using Microsoft.AspNetCore.Components;
using Modelos;
using Proyecto3_Blazor.Interfacez;
//using Proyecto3_Blazor.Servicios;


namespace Proyecto3_Blazor.Pages.Usuarios
{
    //Codigo de C#

    public partial class Usuarios //Partial quiere decir que la clase se puede dividir en varios archivos
    {
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; } //para acceder a los metodos de IUsuarioServicio


        private IEnumerable<Usuario> usuariosLista { get; set; }

        protected virtual async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }

    }
}
