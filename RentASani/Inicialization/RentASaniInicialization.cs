using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IdentitySample.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using RentASani.Models;

namespace RentASani.Inicialization
{
    public class RentASaniInicialization : DropCreateDatabaseIfModelChanges<RentASaniContext>
    {

        protected override void Seed(RentASaniContext context)
        {
            /*
             * 
             * Não consigui encontrar o contexto para tratar as Roles
             * 
             * Deixei este tratamento dentro do IdentityConfig
             * 
            var roleS = HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
           // var roleManager = HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
            var papeis = new List<string>
            {
                "Administrador","Atendente","Cliente","Almoxarife"
            };
            */

            var situacaos = new List<Situacao>
            {
                new Situacao{
                    SituacaoId = 1,
                    Descricao = "Reserva"
                },
                new Situacao{
                    SituacaoId = 2,
                    Descricao = "Aluguel"
                }
            };
            foreach(Situacao situacao in situacaos) {
	          context.Situacaos.Add(situacao);
            }

            context.SaveChanges();
        }

    }
}