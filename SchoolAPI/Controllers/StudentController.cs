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

        [Route("GetAll")]
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

        [Route("GetById")]
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

        [Route("GetByName")]
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

        [Route("Add")]
        [HttpPost]
        public IActionResult Add([FromBody] StudentEntity school)
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

        [Route("DeleteById")]
        [HttpPost]
        public IActionResult Delete([FromBody] long id)
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

        [Route("DeleteByName")]
        [HttpPost]
        public IActionResult DeleteByName([FromBody] string name)
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

        [Route("Update")]
        [HttpPut]
        public void Update(StudentEntity student)
        {
            studentBusiness.Update(student);
        }
    }
}
