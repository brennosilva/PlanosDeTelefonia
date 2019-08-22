using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;

namespace PlanosDeTelefonia.Dominio.Repositorios
{
    public interface IPlanoRepositorio
    {
        Plano BuscarPorTipo(TipoPlano tipo);
        Plano BuscarPorOperadora(Operadora idOperadora);
        Plano BuscarPorID(int idPlano);

    }
}