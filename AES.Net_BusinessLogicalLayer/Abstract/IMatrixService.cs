using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Abstract
{
    public interface IMatrixService
    {
        List<Matrix> GetAll();
        List<Matrix> GetAllWithID(object id);
        bool Add(Matrix entity);
        bool Update(Matrix entity);
        bool Delete(int id);

    }
}
