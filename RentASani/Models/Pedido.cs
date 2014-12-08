using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IdentitySample.Models;
using Microsoft.AspNet.Identity;
namespace RentASani.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }

        public virtual ExtensaoUsuario Vendedor { get; set; }

        public virtual ExtensaoUsuario Cliente { get; set; }

        public Situacao Situacao { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

    }
}