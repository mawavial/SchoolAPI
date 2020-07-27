using Domain.Entity;
using Domain.Interface.IBusiness;
using Domain.Interface.IData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public class StudentBusiness : IStudentBusiness
    {
        private readonly IStudentData studentData;
        public StudentBusiness(IStudentData studentData)
        {
            this.studentData = studentData;
        }

        public void Add(StudentEntity student)
        {
            studentData.Add(student);
        }

        public List<StudentEntity> GetAll()
        {
            return studentData.GetAll();
        }

        public StudentEntity GetById(long id)
        {
            return studentData.GetById(id);
        }

        public StudentEntity GetByName(string name)
        {
            return studentData.GetByName(name);
        }

        public void DeleteById(long id)
        {
            studentData.DeleteById(id);
        }

        public void DeleteByName(string name)
        {
            studentData.DeleteById(studentData.GetByName(name).Id);
        }


    }
}
