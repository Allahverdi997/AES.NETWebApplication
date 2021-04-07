using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class SaheManager : ISaheService
    {
        private ISaheDal saheDal;
        public SaheManager(ISaheDal _saheDal)
        {
            saheDal = _saheDal;
        }
        public bool Add(Sahe entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Sahe id)
        {
            throw new NotImplementedException();
        }

        public List<Sahe> GetAll()
        {
            return saheDal.GetAll();
        }

        public List<Sahe> GetAllWithID(object id)
        {
            return saheDal.GetAllWithID(id);
        }

        public bool Update(Sahe entity)
        {
            throw new NotImplementedException();
        }
    }
}
