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

        [ActionName("GetById")]
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
        [ActionName("GetByName")]
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

        [HttpPost]
        public IActionResult Add(SchoolEntity school)
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

        [HttpDelete]
        public IActionResult Delete(long id)
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

        [HttpDelete]
        public IActionResult DeleteByName(string name)
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
        

    }
}
