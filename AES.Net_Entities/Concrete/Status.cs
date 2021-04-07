using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Status:IEntity
    {
        public string ID { get; set; }
        public string NAME { get; set; }
    }
}
