using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.IBusiness
{
    public interface IClassBusiness
    {
        void Add(ClassEntity classE);
        List<ClassEntity> GetAll();
        ClassEntity GetById(long id);
        ClassEntity GetByName(string name);
        ClassEntity GetByYear(int year);
        void DeleteById(long id);
        void Update(ClassEntity classE);

    }
}
