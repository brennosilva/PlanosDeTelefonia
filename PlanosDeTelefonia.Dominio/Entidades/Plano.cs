using System.Collections.Generic;
using PlanosDeTelefonia.Dominio.Enums;

namespace PlanosDeTelefonia.Dominio.Entidades
{
    public class Plano
    {
        public virtual int Codigo { get; set; }
        public virtual int Minutos { get; set; }
        public virtual string FranquiaDeInternet { get; set; }
        public virtual float Valor { get; set; }
        public virtual TipoPlano Tipo { get; set; }
        public virtual Operadora Operadora { get; set; }
        public virtual List<DDD> DDDs { get; set; }
    }
}