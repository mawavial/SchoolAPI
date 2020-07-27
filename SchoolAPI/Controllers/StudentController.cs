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
    public class StudentController : Controller
    {
        private readonly IStudentBusiness studentBusiness;
        public StudentController(IStudentBusiness studentBusiness)
        {
            this.studentBusiness = studentBusiness;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(studentBusiness.GetAll());
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
                return Ok(studentBusiness.GetById(id));
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
                return Ok(studentBusiness.GetByName(name));
            }
            catch (Exception)
            {
                return BadRequest("Não foi possível completar a requisição");
                throw;
            }

        }

        [HttpPost]
        public IActionResult Add(StudentEntity school)
        {
            try
            {
                studentBusiness.Add(school);
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
                studentBusiness.DeleteById(id);
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
                studentBusiness.DeleteByName(name);
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
