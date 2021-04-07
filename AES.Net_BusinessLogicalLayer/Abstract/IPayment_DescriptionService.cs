using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IPayment_DescriptionService
    {
        List<Payment_Description> GetAll();
        List<Payment_Description> GetAllWithID(object id);
        bool Add(Payment_Description entity);
        bool Update(Payment_Description entity);
        bool Delete(Payment_Description id);
    }
}
