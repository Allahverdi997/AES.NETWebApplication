using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IAccept_PaymentService
    {
        List<Accept_Payment> GetAll();
        List<Accept_Payment> GetAllWithID(object id);
        bool Add(Accept_Payment entity);
        bool Update(Accept_Payment entity);
        bool Delete(Accept_Payment id);
    }
}
