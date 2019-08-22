using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;
using PlanosDeTelefonia.Dominio.Repositorios;

namespace PlanosDeTelefonia.Infraestrutura.DAO
{
    public class PlanoDAO : IPlanoRepositorio
    {
        public Plano BuscarPorID(int idPlano)
        {
            throw new System.NotImplementedException();
        }

        public Plano BuscarPorOperadora(Operadora idOperadora)
        {
            throw new System.NotImplementedException();
        }

        public Plano BuscarPorTipo(TipoPlano tipo)
        {
            throw new System.NotImplementedException();
        }
    }
}