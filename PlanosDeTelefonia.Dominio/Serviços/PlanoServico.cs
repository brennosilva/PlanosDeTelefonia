using System.Collections.Generic;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;
using PlanosDeTelefonia.Dominio.Repositorios;

namespace PlanosDeTelefonia.Dominio.Serviços
{
    public class PlanoServico
    {
        IPlanoRepositorio respositorio;
        public PlanoServico(IPlanoRepositorio respositorio) => this.respositorio = respositorio;

        public IList<Plano> BuscarPorTipo(TipoPlano tipo)
        {
            using(respositorio)
            {
                var plano = respositorio.BuscarPorTipo(tipo);
                return plano;
            }
        }
      
    }
}