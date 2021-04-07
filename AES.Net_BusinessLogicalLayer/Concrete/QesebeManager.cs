using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class QesebeManager : IQesebeService
    {

        private IQesebeDal qesebeDal;
        public QesebeManager(IQesebeDal _qesebeDal)
        {
            qesebeDal = _qesebeDal;
        }

        public bool Add(Qesebe entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Qesebe id)
        {
            throw new NotImplementedException();
        }

        public List<Qesebe> GetAll()
        {
            return qesebeDal.GetAll();
        }

        public List<Qesebe> GetAllWithID(object id)
        {
            return qesebeDal.GetAllWithID(id);
        }

        public bool Update(Qesebe entity)
        {
            throw new NotImplementedException();
        }
    }
}
