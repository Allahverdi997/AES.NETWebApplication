using AES.Net_BusinessLogicalLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IMatrixService matrixService { get; }
        public IStreetService streetService { get;  }
        public ISubcontrolService subcontrolService { get; }
        public IPaymentService paymentService { get; }
        public ISubjectService subjectService { get; }
        public ISubmeterService submeterService { get;  }
        public ISubscriberService subscriberService { get; }
        public IPersonelIdSeqService personelIdSeqService { get; }
        public IQesebeService qesebeService { get;  }
        public ISaheService saheService { get; }
        public IStatusService statusService { get; }
        public ITarifService tarifService { get; }
        public IAccept_PaymentService accept_PaymentService { get; }
        public IMenzilTipiService menzilTipiService { get; }
        public IPayment_DescriptionService payment_DescriptionService { get; }
    }

}
