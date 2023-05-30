using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaz
{
    public interface IUsuarioRepository
    {
        Task<List<IUsuario>> GetUsuarios();
    }
}
