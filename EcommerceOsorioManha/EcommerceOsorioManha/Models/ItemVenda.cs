using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.Models
{
    public class ItemVenda
    {

        public int ItemVendaId { get; set; }

        public Produto Produto { get; set; }

        public int Qtd { get; set; }

        public int Preco { get; set; }

        public DateTime DataEntrega { get; set; }

        
    }
}