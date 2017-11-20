using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEstabelecimentoRepository
    {
        void Add(Estabelecimento estabelecimento);
        void Edit(Estabelecimento estabelecimento);
        void Remove(int Id);
        List<Estabelecimento> GetEstabelecimentos();
        Estabelecimento GetEstabelecimentoById(int Id);
    }
}
