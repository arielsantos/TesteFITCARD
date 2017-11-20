using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFitcard.Models.Categoria
{
    public class EditarCategoriaModel
    {      
        public int CategoriaId { get; set; }
        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }
    }
}