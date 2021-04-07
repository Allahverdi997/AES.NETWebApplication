using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class Accept_PaymentManager: IAccept_PaymentService
    {
        private IAccept_PaymentDal accept_PaymentDal;
        public Accept_PaymentManager(IAccept_PaymentDal _accept_PaymentDal)
        {
            accept_PaymentDal = _accept_PaymentDal;
        }
        public bool Add(Accept_Payment entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Accept_Payment id)
        {
            throw new NotImplementedException();
        }

        public List<Accept_Payment> GetAll()
        {
            return accept_PaymentDal.GetAll();
        }

        public List<Accept_Payment> GetAllWithID(object id)
        {
            return accept_PaymentDal.GetAllWithID(id);
        }
        public bool Update(Accept_Payment entity)
        {
            throw new NotImplementedException();
        }
    }
}
