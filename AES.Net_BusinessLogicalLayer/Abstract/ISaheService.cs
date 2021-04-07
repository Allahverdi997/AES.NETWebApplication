using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface ISaheService
    {
        List<Sahe> GetAll();
        List<Sahe> GetAllWithID(object id);
        bool Add(Sahe entity);
        bool Update(Sahe entity);
        bool Delete(Sahe id);
    }
}
