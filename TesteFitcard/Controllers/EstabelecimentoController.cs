using Core.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFitcard.Helpers;
using TesteFitcard.Models.Estabelecimento;

namespace TesteFitcard.Controllers
{
    public class EstabelecimentoController : Controller
    {
        // GET: Estabelecimento
        public ActionResult GerenciarEstabelecimentos()
        {
            List<EstabelecimentoModel> listEstabelecimentoModel = new List<EstabelecimentoModel>();
            List<Estabelecimento> listEstabelecimento = new EstabelecimentoRepository().GetEstabelecimentos();

            listEstabelecimento.ForEach(delegate (Estabelecimento Estabelecimento)
            {
                listEstabelecimentoModel.Add(new EstabelecimentoModel()
                {
                    EstabelecimentoId = Estabelecimento.EstabelecimentoId,
                    Categoria = Estabelecimento.Categoria.Descricao,
                    RazaoSocial = Estabelecimento.RazaoSocial,
                    NomeFantasia = Estabelecimento.NomeFantasia,
                    CNPJ = Estabelecimento.CNPJ,
                    Email = Estabelecimento.Email,
                    Endereco = Estabelecimento.Endereco,
                    Cidade = Estabelecimento.Cidade,
                    Estado = Estabelecimento.Estado,
                    Telefone = Estabelecimento.Telefone,
                    DataCadastro = Estabelecimento.DataCadastro,
                    Status = Estabelecimento.Status

                    //  Descricao = Estabelecimento.Descricao
                });
            });
          
            return View(listEstabelecimentoModel);
        }

        public ActionResult AdicionarEstabelecimento()
        {
            AdicionarEstabelecimentoModel adicionarEstabelecimento = new AdicionarEstabelecimentoModel();

            adicionarEstabelecimento.Categorias = new SelectList(new CategoriaRepository().GetCategorias(), "CategoriaId", "Descricao");

            return View(adicionarEstabelecimento);
        }
        [HttpPost]
        public ActionResult AdicionarEstabelecimento(AdicionarEstabelecimentoModel adicionarEstabelecimento)
        {
            if (adicionarEstabelecimento.CategoriaId == 1 && String.IsNullOrEmpty(adicionarEstabelecimento.Telefone))
            {
                ModelState.AddModelError(string.Empty, "Telefone obrigatório para supermercados");
                              
                adicionarEstabelecimento.Categorias = new SelectList(new CategoriaRepository().GetCategorias(), "CategoriaId", "Descricao");


                return View(adicionarEstabelecimento);
            }


            Estabelecimento Estabelecimento = new Estabelecimento()
            {
                CategoriaId = adicionarEstabelecimento.CategoriaId,
                RazaoSocial = adicionarEstabelecimento.RazaoSocial,
                NomeFantasia = adicionarEstabelecimento.NomeFantasia,
                CNPJ = adicionarEstabelecimento.CNPJ,
                Email = adicionarEstabelecimento.Email,
                Endereco = adicionarEstabelecimento.Endereco,
                Cidade = adicionarEstabelecimento.Cidade,
                Estado = adicionarEstabelecimento.Estado,
                Telefone = adicionarEstabelecimento.Telefone,
                DataCadastro = adicionarEstabelecimento.DataCadastro,
                Status = adicionarEstabelecimento.Status
            };

            new EstabelecimentoRepository().Add(Estabelecimento);
            this.AddNotification("Estabelecimento incluido com sucesso", NotificationType.SUCCESS);


            return RedirectToAction("GerenciarEstabelecimentos");
        }

        public ActionResult EditarEstabelecimento(int EstabelecimentoId)
        {

            Estabelecimento Estabelecimento = new EstabelecimentoRepository().GetEstabelecimentoById(EstabelecimentoId);


            EditarEstabelecimentoModel visualizarEstabelecimento = new EditarEstabelecimentoModel()
            {
                EstabelecimentoId = Estabelecimento.EstabelecimentoId,
                CategoriaId = Estabelecimento.CategoriaId,
                RazaoSocial = Estabelecimento.RazaoSocial,
                NomeFantasia = Estabelecimento.NomeFantasia,
                CNPJ = Estabelecimento.CNPJ,
                Email = Estabelecimento.Email,
                Endereco = Estabelecimento.Endereco,
                Cidade = Estabelecimento.Cidade,
                Estado = Estabelecimento.Estado,
                Telefone = Estabelecimento.Telefone,
                DataCadastro = Estabelecimento.DataCadastro,
                Status = Estabelecimento.Status
            };

        


            return View(visualizarEstabelecimento);
        }

        [HttpPost]
        public ActionResult EditarEstabelecimento(EditarEstabelecimentoModel editarEstabelecimento)
        {
            if (editarEstabelecimento.CategoriaId == 1 && String.IsNullOrEmpty(editarEstabelecimento.Telefone))
            {
                ModelState.AddModelError(string.Empty, "Telefone obrigatório para supermercados");

                editarEstabelecimento.Categorias = new SelectList(new CategoriaRepository().GetCategorias(), "CategoriaId", "Descricao");


                return View(editarEstabelecimento);
            }


            Estabelecimento Estabelecimento = new Estabelecimento()
            {
                EstabelecimentoId = editarEstabelecimento.EstabelecimentoId,
                CategoriaId = editarEstabelecimento.CategoriaId,
                RazaoSocial = editarEstabelecimento.RazaoSocial,
                NomeFantasia = editarEstabelecimento.NomeFantasia,
                CNPJ = editarEstabelecimento.CNPJ,
                Email = editarEstabelecimento.Email,
                Endereco = editarEstabelecimento.Endereco,
                Cidade = editarEstabelecimento.Cidade,
                Estado = editarEstabelecimento.Estado,
                Telefone = editarEstabelecimento.Telefone,
                DataCadastro = editarEstabelecimento.DataCadastro,
                Status = editarEstabelecimento.Status
            };


            new EstabelecimentoRepository().Edit(Estabelecimento);
            this.AddNotification("Estabelecimento editado com sucesso", NotificationType.SUCCESS);



            return RedirectToAction("GerenciarEstabelecimentos");
        }

        public ActionResult VisualizarEstabelecimento(int EstabelecimentoId)
        {

            Estabelecimento Estabelecimento = new EstabelecimentoRepository().GetEstabelecimentoById(EstabelecimentoId);

            VisualizarEstabelecimentoModel visualizarEstabelecimento = new VisualizarEstabelecimentoModel()
            {
                EstabelecimentoId = Estabelecimento.EstabelecimentoId,
                Categoria = Estabelecimento.Categoria.Descricao,
                RazaoSocial = Estabelecimento.RazaoSocial,
                NomeFantasia = Estabelecimento.NomeFantasia,
                CNPJ = Estabelecimento.CNPJ,
                Email = Estabelecimento.Email,
                Endereco = Estabelecimento.Endereco,
                Cidade = Estabelecimento.Cidade,
                Estado = Estabelecimento.Estado,
                Telefone = Estabelecimento.Telefone,
                DataCadastro = Estabelecimento.DataCadastro,
                Status = Estabelecimento.Status
            };


            return View(visualizarEstabelecimento);
        }

        public ActionResult ExcluirEstabelecimento(int estabelecimentoId)
        {
            new EstabelecimentoRepository().Remove(estabelecimentoId);
            //ModelState.AddModelError(string.Empty, "Student Name already exists.");
            this.AddNotification("Estabelecimento excluido com sucesso", NotificationType.SUCCESS);


            return RedirectToAction("GerenciarEstabelecimentos");
        }


        public ActionResult ValidaCNPJ(string CNPJ)
            {
            string strCNPJ = CNPJ.Replace(".", "");
            strCNPJ = strCNPJ.Replace("/", "");
            strCNPJ = strCNPJ.Replace("-", "");
            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;
            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;
            try
            {
                if (strCNPJ.Equals("00000000000000"))
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    for (nrDig = 0; nrDig < 14; nrDig++)
                    {
                        digitos[nrDig] = int.Parse(
                            strCNPJ.Substring(nrDig, 1));
                        if (nrDig <= 11)
                            soma[0] += (digitos[nrDig] *
                              int.Parse(ftmt.Substring(
                              nrDig + 1, 1)));
                        if (nrDig <= 12)
                            soma[1] += (digitos[nrDig] *
                              int.Parse(ftmt.Substring(
                              nrDig, 1)));
                    }
                    for (nrDig = 0; nrDig < 2; nrDig++)
                    {
                        resultado[nrDig] = (soma[nrDig] % 11);
                        if ((resultado[nrDig] == 0) || (
                             resultado[nrDig] == 1))
                            CNPJOk[nrDig] = (
                            digitos[12 + nrDig] == 0);
                        else
                            CNPJOk[nrDig] = (
                            digitos[12 + nrDig] == (
                            11 - resultado[nrDig]));
                    }
                    return Json((CNPJOk[0] && CNPJOk[1]), JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

     
    }
}