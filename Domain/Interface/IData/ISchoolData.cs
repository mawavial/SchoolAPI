using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.IData
{
    public interface ISchoolData
    {
        void Add(SchoolEntity school);
        List<SchoolEntity> GetAll();
        SchoolEntity GetById(long id);
        SchoolEntity GetByName(string name);
        void DeleteById(long id);
    }
}
