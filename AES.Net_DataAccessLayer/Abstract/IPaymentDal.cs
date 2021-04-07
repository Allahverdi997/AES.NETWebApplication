using AES.Net_CoreLayer.DataAccessLayer.Ado.Net;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_DataAccessLayer.Abstract
{
    public interface IPaymentDal: IEntityRepository<Payment>
    {
        public List<Payment> SelectPayment(string SUBID,DateTime DDATE, int CHARGE, string FORM_OF_PAYMENT);
        public bool UpdatePayment(Payment payment, DateTime old_DDATE);
        public bool DeletePayment(string SUBID, DateTime DDATE, int CHARGE);
    }
}
