using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFitcard.Models.Categoria
{
    public class AdicionarCategoriaModel
    {
        [Required]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
    }
}