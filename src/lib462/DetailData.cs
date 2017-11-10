namespace NetArgenSearch
{
    public class DetailData
    {
        public long IdPersona { get; set; }
        public string TipoPersona { get; set; }
        public string TipoClave { get; set; }
        public string EstadoClave { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DomicilioFiscal DomicilioFiscal { get; set; }
        public int? IdDependencia { get; set; }
        public int? MesCierre { get; set; }
        public string FechaInscripcion { get; set; }
    }
}
