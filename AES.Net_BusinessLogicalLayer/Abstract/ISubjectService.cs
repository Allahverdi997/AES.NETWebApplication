using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface ISubjectService
    {
        List<Subject> GetAll();
        List<Subject> GetAllWithID(object id);
        bool Add(Subject entity);
        bool Update(Subject entity);
        bool Delete(int id);
    }
}
