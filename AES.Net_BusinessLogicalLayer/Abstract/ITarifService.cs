using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface ITarifService
    {
        List<Tarif> GetAll();
        List<Tarif> GetAllWithID(object id);
        bool Add(Tarif entity);
        bool Update(Tarif entity);
        bool Delete(Tarif id);
    }
}
