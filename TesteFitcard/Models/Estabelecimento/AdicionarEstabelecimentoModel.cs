using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteFitcard.Models.Estabelecimento
{
    public class AdicionarEstabelecimentoModel
    {
        [Required]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        [Required]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }
       
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [Required]
        [Display(Name = "CNPJ")]
        [System.Web.Mvc.Remote("ValidaCNPJ", "Estabelecimento", AreaReference.UseRoot)]
        public string CNPJ { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
        [Display(Name = "Data de Cadastro")]
        public string DataCadastro { get; set; }
        [Display(Name = "Status")]
        public bool Status { get; set; }


        public SelectList Categorias { get; set; }
    }
}