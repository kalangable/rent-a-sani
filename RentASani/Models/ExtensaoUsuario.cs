using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentASani.Models
{
    public class ExtensaoUsuario : IdentityUser
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
    }
}