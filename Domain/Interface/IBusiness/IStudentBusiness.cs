using Domain.Entity;
using System.Collections.Generic;

namespace Domain.Interface.IBusiness
{
    public interface IStudentBusiness
    {
        void Add(StudentEntity student);
        List<StudentEntity> GetAll();
        StudentEntity GetById(long id);
        StudentEntity GetByName(string name);
        void DeleteById(long id);
        void DeleteByName(string name);
        public void Update(StudentEntity student);

    }


}
