using AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Concrete;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_DataAccessLayer.Concrete.Ado.Net
{
    public class SaheDal: EntityRepository<Sahe>, ISaheDal
    {
    }
}
