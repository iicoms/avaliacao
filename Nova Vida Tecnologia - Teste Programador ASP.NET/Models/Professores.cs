using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Models
{
    [Table("Professores")]
    public class Professores
    {
        public int ID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do professor é obrigatório")]
        public string Nome { get; set; }
        public DateTime? UltimaImportacao { get; set; }
    }

    [Table("Alunos")]
    public class Aluno
    {
        public int Alunoid { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do aluno é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public Decimal Mensalidade { get; set; }
        public DateTime DtVencimento { get; set; }

        public int Professorid { get; set; }
        public Professores Professor { get; set; }
    }
}
