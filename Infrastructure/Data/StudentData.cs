using Domain.Entity;
using Domain.Interface.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class StudentData : IStudentData
    {

        private readonly SchoolContext context;
        public StudentData(SchoolContext context)
        {
            this.context = context;
        }
        public void Add(StudentEntity student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public List<StudentEntity> GetAll()
        {
            return context.Students.ToList();
        }
        public StudentEntity GetById(long id)
        {
            return context.Students.Where(student => student.Id == id).FirstOrDefault();
        }
        public StudentEntity GetByName(string name)
        {
            return context.Students.Where(student => student.FirstName == name).FirstOrDefault();
        }
        public void DeleteById(long id)
        {
            context.Students.Remove(GetById(id));
        }

        public void Update(StudentEntity student)
        {
            context.Update<StudentEntity>(student);
            context.SaveChanges();
        }


    }
}
