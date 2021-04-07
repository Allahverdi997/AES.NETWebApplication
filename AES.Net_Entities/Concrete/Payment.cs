using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Payment:IEntity
    {
        public string SUBID { get; set; }
        public DateTime DDATE { get; set; }
        public int CHARGE { get; set; }
        public string FORM_OF_PAYMENT { get; set; }
    }
}
