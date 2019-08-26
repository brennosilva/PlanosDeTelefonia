using FluentNHibernate.Mapping;
using PlanosDeTelefonia.Dominio.Entidades;

namespace PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento
{
    public class OperadoraMap : ClassMap<Operadora>
    {
        public OperadoraMap()
        {
            Table("OPERADORA");
            Id(x => x.Codigo).Column("CODIGO_OPERADORA").GeneratedBy.Sequence("SQ_OPERADORA");
            Map(x => x.Nome).Column("NOME");
        }
    }
}