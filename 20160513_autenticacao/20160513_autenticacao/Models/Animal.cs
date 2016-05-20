using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace _20160513_autenticacao.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(30)]
        public string Especie { get; set; }

        [Required]
        [StringLength(30)]
        public string Raca { get; set; }

        public float Peso { get; set; }

        public float? Altura { get; set; }
        // float? faz com que seja facultativo
    }
}