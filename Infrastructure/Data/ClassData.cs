using Domain.Entity;
using Domain.Interface.IData;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class ClassData : IClassData
    {
        private readonly SchoolContext context;
        public ClassData(SchoolContext context)
        {
            this.context = context;
        }
        public void Add(ClassEntity classE)
        {
            context.Classes.Add(classE);
            context.SaveChanges();
        }
        public List<ClassEntity> GetAll()
        {
            return context.Classes.ToList();
        }
        public ClassEntity GetById(long id)
        {
            return context.Classes.Where(classE => classE.id == id).FirstOrDefault();
        }
        public ClassEntity GetByName(string name)
        {
            return context.Classes.Where(classE => classE.YearName == name).FirstOrDefault();
        }

        public ClassEntity GetByYear(int year)
        {
            return context.Classes.Where(classE => classE.Year == year).FirstOrDefault();
        }
        public void DeleteById(long id)
        {
            context.Classes.Remove(GetById(id));
        }

        public void Update(ClassEntity classE)
        {
            context.Update<ClassEntity>(classE);
            context.SaveChanges();
        }

    }
}
