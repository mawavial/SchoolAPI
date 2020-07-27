using Domain.Entity;
using System.Collections.Generic;

namespace Domain.Interface.IBusiness
{
    public interface IStudentBusiness
    {
        public void Add(StudentEntity student);
        public List<StudentEntity> GetAll();
        public StudentEntity GetById(long id);
        public StudentEntity GetByName(string name);
        public void DeleteById(long id);
        public void DeleteByName(string name);
    }

 
}
