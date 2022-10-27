using Entidades.Notificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Produtos")]
    public class Produto : Notificacao
    {
        [Column("PROD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PROD_NOME")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("PROD_VAL")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Column("PROD_ESTADO")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}
