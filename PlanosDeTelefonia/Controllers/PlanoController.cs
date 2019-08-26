using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;
using PlanosDeTelefonia.Dominio.Repositorios;
using PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento;

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
                // IPlanoRepositorio planoRepositorio = new PlanoDAO()
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return null;
        }

        [HttpGet("BuscarPorOperadora")]
        public JsonResult BuscarPorTipo(int operadora)
        {
            try
            {
                // IPlanoRepositorio planoRepositorio = new PlanoDAO()
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return null;
        }

        [HttpGet("BuscarPorId")]
        public JsonResult BuscarPorId(int id)
        {
            try
            {
                // IPlanoRepositorio planoRepositorio = new PlanoDAO()
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return null;
        }

        [HttpDelete("ExcluirPlano")]
        public JsonResult ExcluirPlano(int idPlano)
        {
            try
            {
                // IPlanoRepositorio planoRepositorio = new PlanoDAO()
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return null;
        }

        [HttpPost("CadastrarPlano")]
        public JsonResult CadastrarPlano(Plano Plano)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO(NHibernateSession.OpenSession<PlanoMap>(configuration, "SITEC"));
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return null;
        }
    }
}