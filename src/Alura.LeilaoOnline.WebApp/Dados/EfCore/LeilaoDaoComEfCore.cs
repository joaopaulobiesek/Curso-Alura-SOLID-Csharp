using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {
        AppDbContext _context;

        public LeilaoDaoComEfCore()
        {
            _context = new AppDbContext();
        }

        public Leilao BuscarLeilaoPorId(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public IEnumerable<Categoria> BuscarCategorias() => _context.Categorias;

        public IEnumerable<Leilao> BuscarTodosLeiloes() => _context.Leiloes.Include(l => l.Categoria);

        public void IncluirLeilao(Leilao obj)
        {
            _context.Leiloes.Add(obj);
            _context.SaveChanges();
        }

        public void AlterarLeilao(Leilao obj)
        {
            _context.Leiloes.Update(obj);
            _context.SaveChanges();
        }

        public void ExcluirLeilao(Leilao obj)
        {
            _context.Leiloes.Remove(obj);
            _context.SaveChanges();
        }
    }
}
