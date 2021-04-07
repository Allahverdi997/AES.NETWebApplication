using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class TarifManager : ITarifService
    {
        private ITarifDal tarifDal;
        public TarifManager(ITarifDal _tarifDal)
        {
            tarifDal = _tarifDal;
        }
        public bool Add(Tarif entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Tarif id)
        {
            throw new NotImplementedException();
        }

        public List<Tarif> GetAll()
        {
            return tarifDal.GetAll();
        }

        public List<Tarif> GetAllWithID(object id)
        {
            return tarifDal.GetAllWithID(id);
        }

        public bool Update(Tarif entity)
        {
            throw new NotImplementedException();
        }
    }
}
