using AES.Net_DataTransactObject.Concrete;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AES.Net_CoreMVC_UI.Models
{
    public class AbonentIndexModel
    {
        public List<Subject> Subjects { get; set; }
        public List<Matrix> Matrices { get; set; }
        public List<Street> Streets { get; set; }
        public List<SubscriberSearchDTO> SubscriberSearches { get; set; }
        public SubscriberAddDTO SubscriberAddDTO { get; set; }
        public List<Subscriber> Subscribers { get; set; }
        public Subscriber Subscriber { get; set; }
        public SubscriberSearchDTO SubscriberSearchDTOEntity { get; set; }
        public List<Status> Statuses { get; set; }
        public List<Sahe> Sahes { get; set; }
        public List<Tarif> Tarifs { get; set; }
        public List<Qesebe> Qesebes { get; set; }
        public List<PersonelIdSeq> PersonelIdSeqs { get; set; }
        public List<Accept_Payment> Accept_Payments { get; set; }
        public List<MenzilTipi> MenzilTipis { get; set; }
    }
}
