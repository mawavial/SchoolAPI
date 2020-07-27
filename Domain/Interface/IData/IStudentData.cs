using Domain.Entity;
using System.Collections.Generic;

namespace Domain.Interface.IData
{
    public interface IStudentData
    {
        void Add(StudentEntity student);
        List<StudentEntity> GetAll();
        StudentEntity GetById(long id);
        StudentEntity GetByName(string name);
        void DeleteById(long id);
        void Update(StudentEntity student);

    }
}
