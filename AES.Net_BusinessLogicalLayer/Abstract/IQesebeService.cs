using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IQesebeService
    {
        List<Qesebe> GetAll();
        List<Qesebe> GetAllWithID(object id);
        bool Add(Qesebe entity);
        bool Update(Qesebe entity);
        bool Delete(Qesebe id);
    }
}
