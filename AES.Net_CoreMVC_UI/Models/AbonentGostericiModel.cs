using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AES.Net_CoreMVC_UI.Models
{
    public class AbonentGostericiModel
    {
        public string SubscribeSUBID { get; set; }
        public List<Subcontrol> Submeters { get; set; }
        public Subcontrol Submeter { get; set; }
        public List<PersonelIdSeq> PersonelIdSeqs { get; set; }
    }
}
