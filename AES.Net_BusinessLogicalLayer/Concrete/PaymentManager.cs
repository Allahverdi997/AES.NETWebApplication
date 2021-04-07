using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class PaymentManager:IPaymentService
    {
        private IPaymentDal paymentDal;
        public PaymentManager(IPaymentDal _paymentDal)
        {
            paymentDal = _paymentDal;
        }
        public bool Add(Payment entity)
        {
            return paymentDal.Add(entity);
        }

        public bool Delete(string SUBID,DateTime DDATE,int CHARGE)
        {
            bool result = paymentDal.DeletePayment(SUBID, DDATE, CHARGE);
            return result;
        }

        public List<Payment> GetAll()
        {
            return paymentDal.GetAll();
        }

        public List<Payment> GetAllWithID(string SUBID,DateTime DDATE, int CHARGE, string FORM_OF_PAYMENT)
        {
            return paymentDal.SelectPayment(SUBID, DDATE, CHARGE, FORM_OF_PAYMENT);
        }

        public List<Payment> GetAllWithSUBID(object SUBID)
        {
            return paymentDal.GetAllWithID(SUBID);
        }

        public bool Update(Payment entity)
        {
            return paymentDal.Update(entity);
        }

        public bool UpdatePayment(Payment entity, DateTime old_DDATE)
        {
            return paymentDal.UpdatePayment(entity, old_DDATE);
        }
    }
}
