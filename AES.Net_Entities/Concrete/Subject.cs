using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Subject:IEntity
    {
        public string SUBJECTID { get; set; }
        public string NAME { get; set; }
        public int DIVISIONID { get; set; }
    }
}
