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

        public ActionResult Index()
        {
            ViewBag.Data = DateTime.Now;
            var produtos = new ProdutosViewModel
            {
                Produtos = ProdutoDAO.RetornarProdutosHome(null)
            };
            return View(produtos);
        }

    }
}