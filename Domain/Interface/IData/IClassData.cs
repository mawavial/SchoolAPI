using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.IData
{
    public interface IClassData
    {
        void Add(ClassEntity classE);
        List<ClassEntity> GetAll();

        ClassEntity GetById(long id);

        ClassEntity GetByName(string name);

        ClassEntity GetByYear(int year);

        void DeleteById(long id);

        public void Update(ClassEntity classE);
    }

}
