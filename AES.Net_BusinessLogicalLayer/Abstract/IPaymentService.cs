using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IPaymentService
    {
        List<Payment> GetAll();
        List<Payment> GetAllWithID(string SUBID,DateTime DDATE, int CHARGE, string FORM_OF_PAYMENT);
        List<Payment> GetAllWithSUBID(object SUBID);
        bool Add(Payment entity);
        bool Update(Payment entity);
        bool UpdatePayment(Payment entity, DateTime old_DDATE);
        bool Delete(string SUBID, DateTime DDATE,int CHARGE);
    }
}
