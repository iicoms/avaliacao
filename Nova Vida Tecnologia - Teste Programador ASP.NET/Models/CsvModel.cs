using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Models
{
    public class CsvModel
    {
        public String NomeAluno { get; set; }
        [StringLength(50)]
        public Decimal ValorMensalidade { get; set; }        
        public String DataVencimento { get; set; }
        
    }
}
