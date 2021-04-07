using AES.Net_DataTransactObject.Concrete;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface ISubscriberService
    {
        List<Subscriber> GetAll();
        List<Subscriber> GetAllWithID(object id);
        bool Add(SubscriberAddDTO entity);
        bool Update(SubscriberAddDTO entity);
        bool Delete(string id);
        List<SubscriberSearchDTO> GetSubscriberSearchDTOs();
        List<SubscriberSearchDTO> GetSubscriberSearchDTOEntitiy(string id);
    }
}
