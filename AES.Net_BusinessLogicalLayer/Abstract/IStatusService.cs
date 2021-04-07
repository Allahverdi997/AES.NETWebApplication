using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IStatusService
    {
        List<Status> GetAll();
        List<Status> GetAllWithID(object id);
        bool Add(Status entity);
        bool Update(Status entity);
        bool Delete(Status id);
    }
}
