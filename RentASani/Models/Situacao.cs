using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentASani.Models
{
    public class Situacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SituacaoId { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}