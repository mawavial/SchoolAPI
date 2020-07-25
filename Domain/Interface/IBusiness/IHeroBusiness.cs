using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.IBusiness
{
    public interface IHeroBusiness
    {
        List<HeroEntity> GetAll();
    }
}
