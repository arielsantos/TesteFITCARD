using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFitcard.Models.Categoria
{
    public class VisualizarCategoriaModel
    {
        [Display(Name = "Id")]
        public int CategoriaId { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}