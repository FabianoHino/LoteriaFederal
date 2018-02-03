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
    public class ConfiguraController
    {
        [HttpGet]
        public IJogoInterface Get()
        {
            return new MegaSena();
        }
    }
}
