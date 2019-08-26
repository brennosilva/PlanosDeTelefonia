using FluentNHibernate.Mapping;
using PlanosDeTelefonia.Dominio.Entidades;

namespace PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento
{
    public class OperadoraMap : ClassMap<Operadora>
    {
        public OperadoraMap()
        {
            Table("");
            Id(x => x.Codigo).Column("");
            Map(x => x.Nome).Column("");
        }
    }
}