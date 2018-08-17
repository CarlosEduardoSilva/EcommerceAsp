using EcommerceOsorioManha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.ViewModels
{
    public class ProdutosViewModel
    {
        public List<Produto> Produtos { get; set; }
        public List<Categoria> Categorias { get; set; }
    }

}