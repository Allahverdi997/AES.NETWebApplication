using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class MenzilTipiManager: IMenzilTipiService
    {
        private IMenzilTipiDal menzilTipiDal;
        public MenzilTipiManager(IMenzilTipiDal _menzilTipiDal)
        {
            menzilTipiDal = _menzilTipiDal;
        }
        public bool Add(MenzilTipi entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(MenzilTipi id)
        {
            throw new NotImplementedException();
        }

        public List<MenzilTipi> GetAll()
        {
            return menzilTipiDal.GetAll();
        }

        public List<MenzilTipi> GetAllWithID(object id)
        {
            return menzilTipiDal.GetAllWithID(id);
        }

        public bool Update(MenzilTipi entity)
        {
            throw new NotImplementedException();
        }
    }
}
