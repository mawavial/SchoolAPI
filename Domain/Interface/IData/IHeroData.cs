using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.IData
{
    public interface IHeroData
    {
        void Add(HeroEntity hero);
        List<HeroEntity> GetAll();
        HeroEntity GetById(long Id);
    }
}
