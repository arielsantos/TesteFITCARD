using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteFitcard.Models.Estabelecimento
{
    public class VisualizarEstabelecimentoModel
    {
        [Display(Name = "Id")]
        public int EstabelecimentoId { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }
       
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }
     
        [Display(Name = "CNPJ")]
        
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


    }
}