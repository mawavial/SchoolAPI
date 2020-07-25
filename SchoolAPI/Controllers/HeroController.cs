using Domain.Interface.IBusiness;
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
            catch (Exception)
            {
                return BadRequest("Não foi possível retornar a chamada");
                throw;
            }
            
        }
    }
}
