using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;
using PlanosDeTelefonia.Dominio.Repositorios;
using PlanosDeTelefonia.Dominio.Serviços;
using PlanosDeTelefonia.Infraestrutura.DAO;
using PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento;
using PlanosDeTelefonia.Infraestrutura.NHibernate;

namespace PlanosDeTelefonia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        IConfiguration configuration;

        public PlanoController(IConfiguration configuration) => this.configuration = configuration;

        [HttpGet("BuscarPorTipo")]
        public JsonResult BuscarPorTipo(TipoPlano tipo)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO(NhibernateHelper.OpenSession(configuration));
                PlanoServico planoServico = new PlanoServico(planoRepositorio);
                var plano = planoServico.BuscarPorTipo(tipo);
                return new JsonResult(plano);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpGet("BuscarPorOperadora")]
        public JsonResult BuscarPorTipo(int idOperadora)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO(NhibernateHelper.OpenSession(configuration));
                PlanoServico planoServico = new PlanoServico(planoRepositorio);
                var plano = planoServico.BuscarPorOperadora(new Operadora { Codigo = idOperadora });
                return new JsonResult(plano);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpGet("BuscarPorId")]
        public JsonResult BuscarPorId(int id)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO(NhibernateHelper.OpenSession(configuration));
                PlanoServico planoServico = new PlanoServico(planoRepositorio);
                var plano = planoServico.BuscarPorID(id);
                return new JsonResult(plano);
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpDelete("ExcluirPlano")]
        public IActionResult ExcluirPlano(int idPlano)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO(NhibernateHelper.OpenSession(configuration));
                PlanoServico planoServico = new PlanoServico(planoRepositorio);
                planoServico.ExcluirPlano(idPlano);
                return Ok();
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }

        [HttpPost("CadastrarPlano")]
        public IActionResult CadastrarPlano(Plano novoPlano)
        {
            try
            {
                IPlanoRepositorio planoRepositorio = new PlanoDAO(NhibernateHelper.OpenSession(configuration));
                PlanoServico planoServico = new PlanoServico(planoRepositorio);
                planoServico.NovoPlano(novoPlano);
                HttpContext.Response.StatusCode = 201;     
                return new JsonResult("Plano cadastrado com sucesso!");              
            }
            catch (System.Exception)
            {
                return new JsonResult("Ocorreu um erro desconhecido!");
            }
        }
    }
}