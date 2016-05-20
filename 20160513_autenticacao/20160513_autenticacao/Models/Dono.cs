using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20160513_autenticacao.Models
{
    public class Dono
    {
        [Key]
        public int DonoId { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(9)]
        public string NIF { get; set; }
    }
}