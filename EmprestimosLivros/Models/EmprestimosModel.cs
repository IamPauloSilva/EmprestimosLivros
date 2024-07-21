using System.ComponentModel.DataAnnotations;

namespace EmprestimosLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Digite o nome do Fornecedor")]
        public string Emprestador { get; set; }

        [Required(ErrorMessage = "Digite o nome do Recebedor")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Livro")]
        public string NomeLivro { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

    }

}
