using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class SubcontrolManager : ISubcontrolService
    {
        private ISubcontrolDal subcontrolDal;
        public SubcontrolManager(ISubcontrolDal _subcontrolDal)
        {
            subcontrolDal = _subcontrolDal;
        }
        public bool Add(Subcontrol entity)
        {
            return subcontrolDal.Add(entity);
        }

        public bool Delete(int id)
        {
            return subcontrolDal.DeleteSubcontrol(id);
        }

        public List<Subcontrol> GetAll()
        {
            return subcontrolDal.GetAll();
        }

        public List<Subcontrol> GetAllWithID(object id)
        {
            return subcontrolDal.GetAllWithID(id);
        }

        public List<Subcontrol> GetSubcontrol(string SUBID, DateTime DDATE)
        {
            return subcontrolDal.SelectSubcontrol(SUBID, DDATE);
        }

        public bool Update(Subcontrol entity)
        {
            return subcontrolDal.Update(entity);
        }

        public bool UpdateSubcontrol(Subcontrol entity, DateTime old_DDATE)
        {
            return subcontrolDal.UpdateSubcontrol(entity, old_DDATE);
        }
    }
}
