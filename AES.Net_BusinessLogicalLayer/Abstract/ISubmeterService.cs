using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface ISubmeterService
    {
        List<Submeter> GetAll();
        List<Submeter> GetAllWithID(object id);
        bool Add(Submeter entity);
        bool Update(Submeter entity);
        bool Delete(int id);
    }
}
