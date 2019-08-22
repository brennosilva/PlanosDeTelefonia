using FluentNHibernate.Mapping;
using PlanosDeTelefonia.Dominio.Entidades;
using PlanosDeTelefonia.Dominio.Enums;

namespace PlanosDeTelefonia.Infraestrutura.DAO.Mapeamento
{
    public class PlanoMap : ClassMap<Plano>
    {
        public PlanoMap()
        {
            Table("");
            Id(p => p.Codigo).Column("");
            Map(p => p.Minutos).Column("");
            Map(p => p.FranquiaDeInternet).Column("");
            Map(p => p.Valor).Column("");
            Map(p => p.Tipo).CustomType<TipoPlano>().Column("");

            References(p => p.Operadora).Column("");
            HasMany(p => p.DDDs).Table("").KeyColumn("");
        }
    }
}