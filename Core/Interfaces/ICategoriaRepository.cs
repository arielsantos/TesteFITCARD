using Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICategoriaRepository
    {
        void Add(Categoria categoria);
        void Edit(Categoria categoria);
        void Remove(int Id);
        List<Categoria> GetCategorias();
        Categoria GetCategoriaById(int Id);
    }
} 

