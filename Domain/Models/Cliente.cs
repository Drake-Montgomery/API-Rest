using System.ComponentModel.DataAnnotations;

namespace Agenda
{
    public class Cliente 
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int? Idade { get; set; } 
        public int? Telefone { get; set; }
        public int ContatoID { get; set; }
        public Contato contato { get; set; }

    }
}