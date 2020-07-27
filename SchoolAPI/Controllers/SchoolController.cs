using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Interface.IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace SchoolAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolBusiness schoolBusiness;
        public SchoolController(ISchoolBusiness schoolBusiness)
        {
            this.schoolBusiness = schoolBusiness;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(schoolBusiness.GetAll());
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
            
        }

        [Route("GetById")]
        [HttpGet]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(schoolBusiness.GetById(id));
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }
        [Route("GetByName")]
        [HttpGet]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(schoolBusiness.GetByName(name));
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }

        }

        [Route("Add")]
        [HttpPost]
        public IActionResult Add([FromBody] SchoolEntity school)
        {
            try
            {
                schoolBusiness.Add(school);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }

        [Route("DeleteById")]
        [HttpPost]
        public IActionResult Delete([FromBody] long id)
        {
            ;
            try
            {
                schoolBusiness.DeleteById(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }

        [Route("DeleteByName")]
        [HttpPost]
        public IActionResult DeleteByName([FromBody] string name)
        {
            try
            {
                schoolBusiness.DeleteByName(name);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }
        [Route("Update")]
        [HttpPut]
        public IActionResult Update(SchoolEntity school)
        {
            try
            {
                schoolBusiness.Update(school);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }


    }
}
