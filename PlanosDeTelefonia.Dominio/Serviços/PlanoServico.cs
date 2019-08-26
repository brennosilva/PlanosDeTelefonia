using System;
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

        public Plano BuscarPorID(int id)
        {
            var plano = respositorio.BuscarPorID(id);
            return plano;
        }

        public IList<Plano> BuscarPorOperadora(Operadora operadora)
        {
            var plano = respositorio.BuscarPorOperadora(operadora);
            return plano;
        }

        public void ExcluirPlano(int id)
        {
            var plano = respositorio.BuscarPorID(id);
            if(plano == null)
                throw new Exception("Plano não existe");
            respositorio.Excluir(plano);
        } 

        public void NovoPlano(Plano novoPlano)
        {
            respositorio.Salvar(novoPlano);
        }
      
    }
}