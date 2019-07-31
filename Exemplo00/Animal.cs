using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    [Table("animais")]
    public class Animal
    {
        [Key] //pode ser feito em uma unica linha separando por virgula
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]/*Estas estão no banco*/
        public string Nome { get; set; }

        [Column("extinto")]
        public bool Extinto { get; set; }

        /*[NotMapped Esta propriedade não está declarada no banco de dados]
        public decimal IMC { get; set; }*/

    }
}
