using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class SubjectManager : ISubjectService
    {
        private ISubjectDal subjectDal;
        public SubjectManager(ISubjectDal _subjectDal)
        {
            subjectDal = _subjectDal;
        }
        public bool Add(Subject entity)
        {
            return subjectDal.Add(entity);
        }

        public bool Delete(int id)
        {
            return true; 
        }

        public List<Subject> GetAll()
        {
            return subjectDal.GetAll();
        }

        public List<Subject> GetAllWithID(object id)
        {
            return subjectDal.GetAllWithID(id);
        }

        public bool Update(Subject entity)
        {
            return subjectDal.Update(entity);
        }
    }
}
