using Domain;
using Microsoft.Extensions.Configuration;
using Repository.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConfiguration _configuration;
        public UsuarioRepository(IConfiguration configuration) {
            _configuration = configuration;
            // Inicializa otros repositorios...
        }
        public async Task<List<IUsuario>> GetUsuarios()
        {
            List<IUsuario> lstUsuario = new List<IUsuario>();
            lstUsuario.Add(new IUsuario { nIdUsuario = 1, sNombre = "Albert", bEstado = true });
            lstUsuario.Add(new IUsuario { nIdUsuario = 2, sNombre = "Henry", bEstado = false});

            return lstUsuario;
        }
    }
    
}

