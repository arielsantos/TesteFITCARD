using Core.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteFitcard.Helpers;
using TesteFitcard.Models.Categoria;

namespace TesteFitcard.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult GerenciarCategorias()
        {
            List<CategoriaModel> listCategoriaModel = new List<CategoriaModel>();
            List<Categoria> listCategoria = new CategoriaRepository().GetCategorias();

            listCategoria.ForEach(delegate (Categoria categoria)
            {
                listCategoriaModel.Add(new CategoriaModel()
                {
                    CategoriaId = categoria.CategoriaId,
                    Descricao = categoria.Descricao
                });
            });

            return View(listCategoriaModel);
        }

        public ActionResult AdicionarCategoria()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdicionarCategoria(AdicionarCategoriaModel adicionarCategoria)
        {
            Categoria categoria = new Categoria()
            {
                Descricao = adicionarCategoria.Descricao
            };

            new CategoriaRepository().Add(categoria);


            return RedirectToAction("GerenciarCategorias");
        }

        public ActionResult EditarCategoria(int categoriaId)
        {

            Categoria categoria = new CategoriaRepository().GetCategoriaById(categoriaId);

            VisualizarCategoriaModel visualizarCategoria = new VisualizarCategoriaModel()
            {
                CategoriaId = categoria.CategoriaId,
                Descricao = categoria.Descricao
            };


            return View(visualizarCategoria);
        }

        [HttpPost]
        public ActionResult EditarCategoria(EditarCategoriaModel editarCategoria)
        {

            Categoria categoria = new Categoria()
            {
                CategoriaId = editarCategoria.CategoriaId,
                Descricao = editarCategoria.Descricao
            };

            new CategoriaRepository().Edit(categoria);


            return RedirectToAction("GerenciarCategorias"); 
        }

        public ActionResult VisualizarCategoria(int categoriaId)
        {

            Categoria categoria = new CategoriaRepository().GetCategoriaById(categoriaId);

            VisualizarCategoriaModel visualizarCategoria = new VisualizarCategoriaModel()
            {
                CategoriaId = categoria.CategoriaId,
                Descricao = categoria.Descricao
            };


            return View(categoria);
        }

        public ActionResult ExcluirCategoria(int categoriaId)
        {

            //ModelState.AddModelError(string.Empty, "Student Name already exists.");
            this.AddNotification("Categoria excluida com sucesso", NotificationType.SUCCESS);


            return RedirectToAction("GerenciarCategorias");
        }
    }
}