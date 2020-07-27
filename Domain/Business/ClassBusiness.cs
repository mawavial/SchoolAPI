using Domain.Entity;
using Domain.Interface.IBusiness;
using Domain.Interface.IData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public class ClassBusiness : IClassBusiness
    {
        private readonly IClassData classData;
        public ClassBusiness(IClassData classData)
        {
            this.classData = classData;
        }

        public void Add(ClassEntity classE)
        {
            classData.Add(classE);
        }
        public List<ClassEntity> GetAll()
        {
            return classData.GetAll();
        }
        public ClassEntity GetById(long id)
        {
            return classData.GetById(id);
        }
        public ClassEntity GetByName(string name)
        {
            return classData.GetByName(name);
        }

        public ClassEntity GetByYear(int year)
        {
            return classData.GetByYear(year);
        }
        public void DeleteById(long id)
        {
            classData.DeleteById(id);
        }
        public void Update(ClassEntity classE)
        {
            classData.Update(classE);
        }

    }
}
