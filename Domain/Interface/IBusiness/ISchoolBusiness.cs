using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Domain.Interface.IBusiness
{
    public interface ISchoolBusiness
    {
        void Add(SchoolEntity school);
        List<SchoolEntity> GetAll();
        SchoolEntity GetById(long id);
        SchoolEntity GetByName(string name);
        void DeleteById(long id);
        void DeleteByName(string name);
        public void Update(SchoolEntity school);

    }
}
