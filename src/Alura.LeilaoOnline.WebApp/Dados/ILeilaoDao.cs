﻿using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        Leilao BuscarLeilaoPorId(int id);

        IEnumerable<Categoria> BuscarCategorias();

        IEnumerable<Leilao> BuscarTodosLeiloes();

        void IncluirLeilao(Leilao obj);

        void AlterarLeilao(Leilao obj);

        void ExcluirLeilao(Leilao obj);
    }
}
