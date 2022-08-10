using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é  Obrigatório ")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Título é  Obrigatório ")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O Gênero não pode Passar de 30 Caracteres ")]

        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A Duração deve ter no mínimo 1 e no máximo 600 Minutos")]
        public int Duracao { get; set; }
      
    }
}
