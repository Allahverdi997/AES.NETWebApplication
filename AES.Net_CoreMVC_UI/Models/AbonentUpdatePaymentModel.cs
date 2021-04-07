using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AES.Net_CoreMVC_UI.Models
{
    public class AbonentUpdatePaymentModel
    {
        public string SUBID { get; set; }
        public DateTime DDATE { get; set; }
        public int CHARGE { get; set; }
        public string FORM_OF_PAYMENT { get; set; }
        public DateTime old_DDATE { get; set; }
        public int old_CHARGE { get; set; }
    }
}
