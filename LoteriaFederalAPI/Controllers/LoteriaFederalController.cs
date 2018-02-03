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
    public class LoteriaFederalController : Controller
    {
        private IMemoryCache _cache;
        private List<Aposta> _apostas;
        private int _id;

        public LoteriaFederalController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;

            if (!_cache.TryGetValue("Id", out _id))
            {
                _cache.Set("Id", 0);
            }

            if (!_cache.TryGetValue("Aposta", out _apostas))
            {
                _cache.Set("Aposta", new List<Aposta>());
            }

        }

        [HttpGet]
        public List<Aposta>  Get() {
            return _cache.Get<List<Aposta>>("Aposta");
        }

        // POST api/values
        [HttpPost]
        public string Post(int[] values)
        {

            List<Aposta> apostas = _cache.Get<List<Aposta>>("Aposta");
            apostas.Add(new Aposta()
            {
                Id = _cache.Get<int>("Id") + 1,
                Numeros = values,
                Data = DateTime.Now.ToString("dd/mm/yyyy - H:mm:ss")
            });
            _cache.Set("Id", _cache.Get<int>("Id") + 1);
            _cache.Set("Aposta", apostas);

            return "sucesso";
        }
    }
}
