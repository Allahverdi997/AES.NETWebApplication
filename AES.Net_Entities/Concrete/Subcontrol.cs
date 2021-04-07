using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Subcontrol:IEntity
    {
        public string SUBID { get; set; }
        public DateTime DDATE { get; set; }
        public int METERVALUE { get; set; }
        public int R_METERVALUE { get; set; }
        public int FARE { get; set; }
        public int R_FARE { get; set; }
        public int VAT_PERCENT { get; set; }
        public string VERIFIED_CH { get; set; }
        public int PERSONEL_ID_SEQ { get; set; }
    }
}
