using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppStartCMD.Core
{
    public class Materia
    {
        public int Id { get; set; }

        [Required, StringLength(300)]
        public string Titulo { get; set; }

        [StringLength(500)]
        public string Resumo { get; set; }

        [Required]
        public string Texto { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Publicado { get; set; }
    }
}
