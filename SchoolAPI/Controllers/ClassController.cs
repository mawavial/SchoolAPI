using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Business;
using Domain.Entity;
using Domain.Interface.IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace SchoolAPI.Controllers
{
    
    public class ClassController : Controller
    {
        private readonly IClassBusiness classBusiness;
        public ClassController(IClassBusiness classBusiness)
        {
            this.classBusiness = classBusiness;
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult Add([FromBody] ClassEntity classE)
        {
            
            try
            {
                classBusiness.Add(classE);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(classBusiness.GetAll());
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
                return Ok(classBusiness.GetById(id));
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
                return Ok(classBusiness.GetByName(name));
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }

        [Route("GetByYear")]
        [HttpGet]
        public IActionResult GetByYear(int year)
        {
            
            try
            {
                return Ok(classBusiness.GetByYear(year));
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }
        }

        [Route("DeleteById")]
        [HttpPost]
        public IActionResult DeleteById([FromBody] long id)
        {
            
            try
            {
                classBusiness.DeleteById(id);
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
        public IActionResult Update(ClassEntity classE)
        {
            try
            {
                classBusiness.Update(classE);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
            
        }


    }
}
