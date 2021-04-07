using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class StreetManager : IStreetService
    {
        private IStreetDal streetDal;
        public StreetManager(IStreetDal _streetDal)
        {
            streetDal = _streetDal;
        }
        public bool Add(Street entity)
        {
            return streetDal.Add(entity);
        }

        public bool Delete(int id)
        {
            return true;
        }

        public List<Street> GetAll()
        {
            return streetDal.GetAll();
        }

        public List<Street> GetAllWithID(object id)
        {
            return streetDal.GetAllWithID(id);
        }

        public bool Update(Street entity)
        {
            return streetDal.Update(entity);
        }
    }
}
