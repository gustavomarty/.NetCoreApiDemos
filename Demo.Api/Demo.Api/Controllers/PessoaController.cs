using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(Pessoa._pessoas);
        }

        [HttpGet("more")]
        public ActionResult<IEnumerable<string>> LoadMore()
        {
            Pessoa.generate(5);
            return Ok(Pessoa._pessoas);
        }
    }
}