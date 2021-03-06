﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceOsorioManha.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo deve ter no maximo 50 caracteres!")]
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }

        [Display(Name = "Descrição do produto")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Preço do produto")]
        public double Preco { get; set; }

        [Display(Name = "Categoria do produto")]
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagem do produto")]
        public string Imagem { get; set; }

    }
}