using Domain.Entity;
using Domain.Interface.IData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class HeroData : IHeroData
    {
        private readonly SchoolContext context;
        public HeroData(SchoolContext context)
        {
            this.context = context;
        }
        public void Add(HeroEntity hero)
        {
            context.Heroes.Add(hero);
            context.SaveChanges();
        }

        public List<HeroEntity> GetAll()
        {
            return context.Heroes.ToList();
        }

        public HeroEntity GetById(long Id)
        {
            return context.Heroes.Where(hero => hero.Id == Id).FirstOrDefault();
        }

    }
}
