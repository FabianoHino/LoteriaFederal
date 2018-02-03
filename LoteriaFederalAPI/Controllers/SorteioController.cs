using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using LoteriaFederalAPI.Model;

namespace LoteriaFederalAPI.Controllers
{
    [Route("api/[controller]")]
    public class SorteioController : Controller
    {
        IJogoInterface jogo;
        public SorteioController()
        {
            jogo = new MegaSena();
        }

        [HttpGet]
        public List<int> Get()
        {
            Random r = new Random();
            int qtdNumeros = jogo.numeroSorteio;

            var numerosGerados = new List<int>();
            var i = 0;
            while (i < qtdNumeros)
            {
                int rInt = r.Next(1, jogo.numeroPossiveis);
                if (numerosGerados.IndexOf(rInt) == -1){
                    numerosGerados.Add(rInt);
                    i++;
                }
            }

            return numerosGerados;
        }
    }
}
