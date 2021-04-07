using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IStreetService
    {
        List<Street> GetAll();
        List<Street> GetAllWithID(object id);
        bool Add(Street entity);
        bool Update(Street entity);
        bool Delete(int id);
    }
}
