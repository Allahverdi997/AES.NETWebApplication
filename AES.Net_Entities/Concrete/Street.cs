using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Street:IEntity
    {
        public string SUBJECTID { get; set; }
        public string MATRIXID { get; set; }
        public string STREETID { get; set; }
        public string NAME { get; set; }
    }
}
