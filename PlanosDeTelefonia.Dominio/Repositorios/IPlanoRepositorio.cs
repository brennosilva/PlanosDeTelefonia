using System;
using System.Collections.Generic;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;

namespace PlanosDeTelefonia.Dominio.Repositorios
{
    public interface IPlanoRepositorio : IDisposable
    {
        IList<Plano> BuscarPorTipo(TipoPlano tipo);
        IList<Plano> BuscarPorOperadora(Operadora operadora);
        Plano BuscarPorID(int idPlano);
        void Salvar(Plano novoPlano);
        void Excluir(Plano Plano);

    }
}