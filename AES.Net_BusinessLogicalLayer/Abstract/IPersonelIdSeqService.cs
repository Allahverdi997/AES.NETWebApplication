using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IPersonelIdSeqService
    {
        List<PersonelIdSeq> GetAll();
        List<PersonelIdSeq> GetAllWithID(object id);
        bool Add(PersonelIdSeq entity);
        bool Update(PersonelIdSeq entity);
        bool Delete(int id);
    }
}
