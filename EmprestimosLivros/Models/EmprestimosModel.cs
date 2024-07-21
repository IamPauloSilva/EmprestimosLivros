namespace EmprestimosLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string Emprestador { get; set; }

        public string Recebedor { get; set; }
        public string NomeLivro { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

    }

}
