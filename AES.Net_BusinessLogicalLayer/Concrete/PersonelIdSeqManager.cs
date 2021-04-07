using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class PersonelIdSeqManager : IPersonelIdSeqService
    {
        private IPersonelIdSeqDal personelIdSeqDal;
        public PersonelIdSeqManager(IPersonelIdSeqDal _personelIdSeqDal)
        {
            personelIdSeqDal = _personelIdSeqDal;
        }
        public bool Add(PersonelIdSeq entity)
        {
            return personelIdSeqDal.Add(entity);
        }

        public bool Delete(int id)
        {
            return true;
        }

        public List<PersonelIdSeq> GetAll()
        {
            return personelIdSeqDal.GetAll();
        }

        public List<PersonelIdSeq> GetAllWithID(object id)
        {
            return personelIdSeqDal.GetAllWithID(id);
        }

        public bool Update(PersonelIdSeq entity)
        {
            return personelIdSeqDal.Update(entity);
        }
    }
}
