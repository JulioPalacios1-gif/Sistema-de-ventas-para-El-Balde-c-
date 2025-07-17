using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos; //Se llama la referencia CapaDatos que fue agregada al proyecto previamente
using CapaEntidad;
namespace CapaNegocio
{
  public  class CN_Usuario
  {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }
  }
}
