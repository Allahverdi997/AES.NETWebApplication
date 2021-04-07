using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_CoreLayer.DataAccessLayer.Ado.Net
{
    public interface IEntityRepository<T>
        where T:class,IEntity,new()
    {
        List<T> GetAll();
        List<T> GetAllWithID(object id);
        T Get(string procName,string id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(string id);
    }
}
