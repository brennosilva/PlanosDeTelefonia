using System;
using System.Collections.Generic;
using NHibernate;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;
using PlanosDeTelefonia.Dominio.Repositorios;

namespace PlanosDeTelefonia.Infraestrutura.DAO
{
    public class PlanoDAO : IPlanoRepositorio
    {
        protected ISession session;

        public PlanoDAO(ISession session)
        {
            this.session = session;
        }
        
        
        public Plano BuscarPorID(int idPlano)
        {
            return session.Get<Plano>(idPlano);
        }

        public IList<Plano> BuscarPorOperadora(Operadora operadora)
        {
            return session.QueryOver<Plano>().Where(x => x.Operadora == operadora).List();
        }

        public IList<Plano> BuscarPorTipo(TipoPlano tipo)
        {
            return session.QueryOver<Plano>().Where(x => x.Tipo == tipo).List();           
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Plano plano)
        {
            session.Delete(plano);
        }

        public void Salvar(Plano novoPlano)
        {
            session.SaveOrUpdate(novoPlano);
        }
    }
}