using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PlanosDeTelefonia.Dominio.Enums;
using PlanosDeTelefonia.Dominio.Repositorios;

namespace PlanosDeTelefonia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        IConfiguration configuration;

        [HttpGet("BuscarPorTipo")]
        public JsonResult BuscarPorTipo(TipoPlano tipo)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO()
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return null;
        }
    }
}