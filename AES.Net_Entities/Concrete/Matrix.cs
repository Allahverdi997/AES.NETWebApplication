using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Matrix:IEntity
    {
        public string SUBJECTID { get; set; }
        public string MATRIXID { get; set; }
        public string NAME { get; set; }
    }
}
