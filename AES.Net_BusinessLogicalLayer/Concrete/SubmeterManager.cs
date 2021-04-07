using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class SubmeterManager : ISubmeterService
    {
        private ISubmeterDal submeterDal;
        public SubmeterManager(ISubmeterDal _submeterDal)
        {
            submeterDal = _submeterDal;
        }
        public bool Add(Submeter entity)
        {
            return submeterDal.Add(entity);
        }

        public bool Delete(int id)
        {
            return true;
        }

        public List<Submeter> GetAll()
        {
            return submeterDal.GetAll();
        }

        public List<Submeter> GetAllWithID(object id)
        {
            return submeterDal.GetAllWithID(id);
        }

        public bool Update(Submeter entity)
        {
            return submeterDal.Update(entity);
        }
    }
}
