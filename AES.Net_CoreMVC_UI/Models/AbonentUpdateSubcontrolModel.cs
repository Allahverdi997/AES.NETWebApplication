using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AES.Net_CoreMVC_UI.Models
{
    public class AbonentUpdateSubcontrolModel
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
        public DateTime old_DDATE { get; set; }
        public int old_PERSONEL_ID_SEQ { get; set; }
    }
}
