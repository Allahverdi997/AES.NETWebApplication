using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class MatrixManager : IMatrixService
    {
        private IMatrixDal matrixDal;
        public MatrixManager(IMatrixDal _matrixDal)
        {
            matrixDal = _matrixDal;
        }
        public bool Add(Matrix entity)
        {
            return matrixDal.Add(entity);
        }

        public bool Delete(int id)
        {
            return true;
        }

        public List<Matrix> GetAll()
        {
            return matrixDal.GetAll();
        }

        public List<Matrix> GetAllWithID(object id)
        {
            return matrixDal.GetAllWithID(id);
        }

        public bool Update(Matrix entity)
        {
            return matrixDal.Update(entity);
        }
    }
}
