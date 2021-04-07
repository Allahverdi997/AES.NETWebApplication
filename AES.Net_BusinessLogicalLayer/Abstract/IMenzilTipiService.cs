using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IMenzilTipiService
    {
        List<MenzilTipi> GetAll();
        List<MenzilTipi> GetAllWithID(object id);
        bool Add(MenzilTipi entity);
        bool Update(MenzilTipi entity);
        bool Delete(MenzilTipi id);
    }
}
