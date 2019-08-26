namespace PlanosDeTelefonia.DTOS
{
    public class PlanoDTO
    {
        public int Codigo { get; set; }
        public int Minutos { get; set; }
        public string FranquiaDeInternet { get; set; }
        public int Valor { get; set; }
        public int Tipo { get; set; }
        public int IdOperadora { get; set; }
        public int DDD { get; set; }
    }
}