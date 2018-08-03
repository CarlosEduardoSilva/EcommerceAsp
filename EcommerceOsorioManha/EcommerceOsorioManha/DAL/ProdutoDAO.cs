using EcommerceOsorioManha.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.DAL
{
    public class ProdutoDAO
    {
        private static Contexto contexto = new Contexto();

        public static List<Produto> RetornarProdutos()
        {
            return contexto.Produtos.ToList();
        }

        public static void CadastrarProduto(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public static void RemoverProduto(int? id)
        {
            try
            {
                contexto.Produtos.Remove(BuscarProdutoPorId(id));
                contexto.SaveChanges();
            }
            catch (Exception)
            {
            }
        }

        public static Produto BuscarProdutoPorId(int? id)
        {
            return contexto.Produtos.Find(id);

        }

        public static void AlterarProduto(Produto produto)
        {

            try
            {
                contexto.Entry(produto).State = EntityState.Modified;
                contexto.SaveChanges();

            }
            catch (Exception)
            {
            }
        }
    }
}