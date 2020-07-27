using Domain.Entity;
using Domain.Interface.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class SchoolData : ISchoolData
    {
        private readonly SchoolContext context;
        public SchoolData(SchoolContext context)
        {
            this.context = context;
        }

        public void Add(SchoolEntity school)
        {
            context.Schools.Add(school);
            context.SaveChanges();
        }
        public List<SchoolEntity> GetAll()
        {
            return context.Schools.ToList();
        }
        public SchoolEntity GetById(long id)
        {
            return context.Schools.Where(school => school.Id == id).FirstOrDefault();
        }
        public SchoolEntity GetByName(string name)
        {
            return context.Schools.Where(school => school.Name == name).FirstOrDefault();
        }
        public void DeleteById(long id)
        {
            context.Schools.Remove(GetById(id));
        }

        public void Update(SchoolEntity school)
        {
            context.Update<SchoolEntity>(school);
            context.SaveChanges();
        }

    }
}
