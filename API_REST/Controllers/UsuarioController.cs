using Domain;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork;

namespace API_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("GetListaUsuario")]
        public async Task<ActionResult<List<IUsuario>>> GetListaUsuario()
        {
            var result =  await _unitOfWork.UsuarioRepository.GetUsuarios();
            return StatusCode(200, result);
        }
    }
}
