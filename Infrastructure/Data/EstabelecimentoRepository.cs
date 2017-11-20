using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{  
    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {
        TesteFitcardContext context = new TesteFitcardContext();
        public void Add(Estabelecimento Estabelecimento)
        {
            context.Estabelecimento.Add(Estabelecimento);
            context.SaveChanges();
        }

        public void Edit(Estabelecimento Estabelecimento)
        {
            context.Entry(Estabelecimento).State = System.Data.Entity.EntityState.Modified;
        }

        public Estabelecimento GetEstabelecimentoById(int estabelecimentoId)
        {
            return context.Estabelecimento.Include("Categoria").Where(c => c.EstabelecimentoId == estabelecimentoId).FirstOrDefault();
        }

        public List<Estabelecimento> GetEstabelecimentos()
        {
            return context.Estabelecimento.Include("Categoria").ToList();
        }

        public void Remove(int estabelecimentoId)
        {
            Estabelecimento Estabelecimento = context.Estabelecimento.Find(estabelecimentoId);
            context.Estabelecimento.Remove(Estabelecimento);
            context.SaveChanges();
        }
    }
}
