﻿using System.Collections.Generic;
using System.Linq;
using LivroCSharp.MinhasClasses;

namespace LivroCSharp.Data 
{
    public class Produtos 
    {
        private static List<Produto> Itens { get; set; }
        public static int ProdutosTotal { get => Itens.Count; }
        public static List<Produto> ProdutosLista { get => Itens; }
        
        static Produtos()
        {
            Itens = new List<Produto>();
        }

        public static void ProdutosIncluir(Produto p)
        {
            Produto produtoEncontrado = ProdutosLista.Find(produtoLista => produtoLista.Codigo == p.Codigo);
            int codigo = 1;

            if(produtoEncontrado != null)
            {
                // Produto já existia na lista
                produtoEncontrado = p;
            }
            else
            {
                // Produto não existia na lista
                int total = ProdutosTotal;

                if (total > 0)
                {
                    codigo = ProdutosLista[total - 1].Codigo + 1;
                }

                p.Codigo = codigo;
                Itens.Add(p);
            }
        }

        public static void ProdutosExcluir(int produtoCodigo)
        {
            Produto produtoEncontrado = Itens.Find(produto => produto.Codigo == produtoCodigo);

            if(produtoEncontrado != null)
            {
                Itens.Remove(produtoEncontrado);
            }
        }

        public static void ProdutosFiltro(string nomeProduto)
        {
            Itens = Itens.FindAll(p => p.Nome == nomeProduto);

        }

    }
}
