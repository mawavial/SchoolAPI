using Domain.Entity;
using Domain.Interface.IBusiness;
using Domain.Interface.IData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    public class SchoolBusiness : ISchoolBusiness
    {
        private readonly ISchoolData schoolData;
        public SchoolBusiness(ISchoolData schoolData)
        {
            this.schoolData = schoolData;
        }

        public void Add(SchoolEntity school)
        {
            schoolData.Add(school);
        }
        public List<SchoolEntity> GetAll()
        {
            return schoolData.GetAll();
        }
        public SchoolEntity GetById(long id)
        {
            return schoolData.GetById(id);
        }
        public SchoolEntity GetByName(string name)
        {
            return schoolData.GetByName(name);
        }
        public void DeleteById(long id)
        {
            schoolData.DeleteById(id);
        }

        public void DeleteByName(string name)
        {
            schoolData.DeleteById(schoolData.GetByName(name).Id);
        }

        public void Update(SchoolEntity school)
        {
            schoolData.Update(school);
        }

    }
}
