using Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IUnitOfWork
    {
        IUsuarioRepository UsuarioRepository { get; }
    }
}
