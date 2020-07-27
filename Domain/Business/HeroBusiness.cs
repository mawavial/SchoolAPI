using Domain.Entity;
using Domain.Interface.IBusiness;
using Domain.Interface.IData;
using System.Collections.Generic;

namespace Domain.Business
{
    public class HeroBusiness : IHeroBusiness
    {
        private readonly IHeroData heroData;
        public HeroBusiness(IHeroData heroData)
        {
            this.heroData = heroData;
        }

        public List<HeroEntity> GetAll()
        {
            return heroData.GetAll();
        }

        public void Add(HeroEntity hero)
        {
            heroData.Add(hero);
        }

        #region mockme
        private List<HeroEntity> mockHeroes()
        {
            var hero1 = new HeroEntity()
            {
                Id = 1,
                Name = "Schawrznagger"
            };
            var hero2 = new HeroEntity()
            {
                Id = 2,
                Name = "Wonder Woman"
            };
            var hero3 = new HeroEntity()
            {
                Id = 3,
                Name = "Jackie Chan"
            };
            var hero4 = new HeroEntity()
            {
                Id = 4,
                Name = "Mike Tyson"
            };

            var heroesList = new List<HeroEntity>();
            heroesList.Add(hero1);
            heroesList.Add(hero2);
            heroesList.Add(hero3);
            heroesList.Add(hero4);

            return heroesList;
        }

        #endregion
    }
}
