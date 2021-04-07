using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface ISubcontrolService
    {
        List<Subcontrol> GetAll();
        List<Subcontrol> GetAllWithID(object id);
        bool Add(Subcontrol entity);
        bool Update(Subcontrol entity);
        bool Delete(int id);
        List<Subcontrol> GetSubcontrol(string SUBID, DateTime DDATE);
        bool UpdateSubcontrol(Subcontrol entity, DateTime old_DDATE);
    }
}
