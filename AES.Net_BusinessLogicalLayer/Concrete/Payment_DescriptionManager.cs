using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class Payment_DescriptionManager: IPayment_DescriptionService
    {
        private IPayment_DescriptionDal payment_DescriptionDal;
        public Payment_DescriptionManager(IPayment_DescriptionDal _payment_DescriptionDal)
        {
            payment_DescriptionDal = _payment_DescriptionDal;
        }
        public bool Add(Payment_Description entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Payment_Description id)
        {
            throw new NotImplementedException();
        }

        public List<Payment_Description> GetAll()
        {
            return payment_DescriptionDal.GetAll();
        }

        public List<Payment_Description> GetAllWithID(object id)
        {
            return payment_DescriptionDal.GetAllWithID(id);
        }

        public bool Update(Payment_Description entity)
        {
            throw new NotImplementedException();
        }
    }
}
