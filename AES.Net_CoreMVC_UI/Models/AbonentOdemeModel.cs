using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AES.Net_CoreMVC_UI.Models
{
    public class AbonentOdemeModel
    {
        public Subscriber Subscriber { get; set; }
        public Payment Payment { get; set; }
        public List<Payment> Payments { get; set; }
        public string   SumPayment { get; set; }
        public List<Payment_Description> Payment_Descriptions { get; set; }
    }
}
