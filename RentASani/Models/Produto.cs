using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RentASani.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo descrição é requerido")]
        public string Descricao { get; set; }
        [Range(10, 99999.99, ErrorMessage = "O Preço de Venda deve estar entre " + "10,00 e 99999,99.")]

        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Imagem")]
        public string Imagem { get; set; }
    }
}