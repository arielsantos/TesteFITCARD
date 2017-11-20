using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CategoriaRepository : ICategoriaRepository
    {
        TesteFitcardContext context = new TesteFitcardContext();
        public void Add(Categoria categoria)
        {
            context.Categoria.Add(categoria);
            context.SaveChanges();
        }

        public void Edit(Categoria categoria)
        {
            context.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
        }

        public Categoria GetCategoriaById(int categoriaId)
        {
            return context.Categoria.Where(c => c.CategoriaId == categoriaId).FirstOrDefault();
        }

        public List<Categoria> GetCategorias()
        {
            return context.Categoria.ToList();
        }

        public void Remove(int categoriaId)
        {
            Categoria categoria = context.Categoria.Find(categoriaId);
            context.Categoria.Remove(categoria);
            context.SaveChanges();
        }
    }
}

