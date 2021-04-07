using AES.Net_CoreLayer.DataAccessLayer.Ado.Net;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_DataAccessLayer.Abstract
{
    public interface ISubcontrolDal:IEntityRepository<Subcontrol>
    {
        public List<Subcontrol> SelectSubcontrol(string SUBID, DateTime DDATE);
        public bool UpdateSubcontrol(Subcontrol subcontrol, DateTime old_DDATE);
        public bool DeleteSubcontrol(int id);
    }
}
