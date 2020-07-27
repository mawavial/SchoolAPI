using Domain.Entity;
using Domain.Interface.IBusiness;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SchoolAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : Controller
    {
        private readonly IHeroBusiness heroBusiness;

        public HeroController(IHeroBusiness heroBusiness)
        {
            this.heroBusiness = heroBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(heroBusiness.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Não foi possível retornar a chamada");
                throw;
            }
        }

        [HttpPost]
        public IActionResult Add(HeroEntity hero)
        {
            try
            {
                heroBusiness.Add(hero);
                return Ok("Herói adicionado com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest("Não foi possível salvar o seu herói");
                throw;
            }
        }
    }
}
