using Microsoft.Extensions.Configuration;
using Repository;
using Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConfiguration _configuration;
        public IUsuarioRepository UsuarioRepository { get; private set; }
        public UnitOfWork (IConfiguration configuration)
        {
            _configuration = configuration;
            UsuarioRepository = new UsuarioRepository(_configuration);
        }
    }
}
