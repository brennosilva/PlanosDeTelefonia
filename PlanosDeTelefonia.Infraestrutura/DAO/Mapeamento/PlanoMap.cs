using FluentNHibernate.Mapping;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;

namespace PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento
{
    public class PlanoMap : ClassMap<Plano>
    {
        public PlanoMap()
        {
            Table("PLANO");
            Id(p => p.Codigo).Column("CODIGO_PLANO");
            Map(p => p.Minutos).Column("MINUTOS");
            Map(p => p.FranquiaDeInternet).Column("FRANQUIA_DE_INTERNET");
            Map(p => p.Valor).Column("VALOR");
            Map(p => p.Tipo).CustomType<TipoPlano>().Column("TIPO");

            References(p => p.Operadora).Column("CODIGO_OPERADORA");
            HasMany(p => p.DDDs).Table("").KeyColumn("CODIGO_DDD");
        }
    }
}