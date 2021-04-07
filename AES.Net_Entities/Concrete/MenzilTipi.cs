using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class MenzilTipi:IEntity
    {
        public int ID { get; set; }
        public string NAME { get; set; }
    }
}
