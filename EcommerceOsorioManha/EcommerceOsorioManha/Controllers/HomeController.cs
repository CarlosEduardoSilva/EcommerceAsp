using EcommerceOsorioManha.DAL;
using EcommerceOsorioManha.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceOsorioManha.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(int? id)
        {
            ViewBag.Data = DateTime.Now;
            var produtos = new ProdutosViewModel
            {
                Produtos = ProdutoDAO.RetornarProdutosHome(id ?? null),
                Categorias = CategoriaDAO.RetornarCategorias()

            };
            return View(produtos);
        }

    }
}