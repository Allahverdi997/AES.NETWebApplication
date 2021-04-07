using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class StatusManager : IStatusService
    {
        private IStatusDal statusDal;
        public StatusManager(IStatusDal _statusDal)
        {
            statusDal = _statusDal;
        }
        public bool Add(Status entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Status id)
        {
            throw new NotImplementedException();
        }

        public List<Status> GetAll()
        {
            return statusDal.GetAll();
        }

        public List<Status> GetAllWithID(object id)
        {
            return statusDal.GetAllWithID(id);
        }

        public bool Update(Status entity)
        {
            throw new NotImplementedException();
        }
    }
}
