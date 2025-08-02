namespace ApiAuditoria.Models
{
    public class ResponseModel<T>
    {
        
        public T? Dados { get; set; }
        public string Mensagem { get; set; }
        public bool Status { get; set; } = true;
    }
}
