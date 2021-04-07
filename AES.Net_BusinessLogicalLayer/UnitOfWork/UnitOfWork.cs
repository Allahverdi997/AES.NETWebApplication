using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_BusinessLogicalLayer.Concrete;
using AES.Net_DataAccessLayer.Concrete;
using AES.Net_DataAccessLayer.Concrete.Ado.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IMatrixService MatrixService { get; set; }
        public IMatrixService matrixService
        {
            get { return MatrixService ?? new MatrixManager(new MatrixDal()); }
        }
        public IStreetService StreetService { get; set; }
        public IStreetService streetService
        {
            get { return StreetService ?? new StreetManager(new StreetDal()); }
        }
        public ISubcontrolService SubcontrolService { get; set; }
        public ISubcontrolService subcontrolService
        {
            get { return SubcontrolService ?? new SubcontrolManager(new SubcontrolDal()); }
        }
        public ISubjectService SubjectService { get; set; }
        public ISubjectService subjectService
        {
            get { return SubjectService ?? new SubjectManager(new SubjectDal()); }
        }
        public ISubmeterService SubmeterService { get; set; }
        public ISubmeterService submeterService
        {
            get { return SubmeterService ?? new SubmeterManager(new SubmeterDal()); }
        }
        public ISubscriberService SubscriberService { get; set; }
        public ISubscriberService subscriberService
        {
            get { return SubscriberService ?? new SubscriberManager(new SubscriberDal()); }
        }

        public IPersonelIdSeqService PersonelIdSeqService { get; set; }
        public IPersonelIdSeqService personelIdSeqService
        {
            get { return PersonelIdSeqService ?? new PersonelIdSeqManager(new PersonelIdSeqDal()); }
        }
        public IQesebeService QesebeService { get; set; }
        public IQesebeService qesebeService
        {
            get { return QesebeService ?? new QesebeManager(new QesebeDal()); }
        }
        public ISaheService SaheService { get; set; }
        public ISaheService saheService
        {
            get { return SaheService ?? new SaheManager(new SaheDal()); }
        }
        public IStatusService StatusService { get; set; }
        public IStatusService statusService
        {
            get { return StatusService ?? new StatusManager(new StatusDal()); }
        }
        public ITarifService TarifService { get; set; }
        public ITarifService tarifService
        {
            get { return TarifService ?? new TarifManager(new TarifDal()); }
        }

        public IPaymentService PaymentService { get; set; }
        public IPaymentService paymentService
        {
            get { return PaymentService ?? new PaymentManager(new PaymentDal()); }
        }

        public IAccept_PaymentService Accept_PaymentService { get; set; }
        public IAccept_PaymentService accept_PaymentService
        {
            get { return Accept_PaymentService ?? new Accept_PaymentManager(new Accept_PaymentDal()); }
        }

        public IMenzilTipiService MenzilTipiService { get; set; }
        public IMenzilTipiService menzilTipiService
        {
            get { return MenzilTipiService ?? new MenzilTipiManager(new MenzilTipiDal()); }
        }

        public IPayment_DescriptionService Payment_DescriptionService { get; set; }
        public IPayment_DescriptionService payment_DescriptionService
        {
            get { return Payment_DescriptionService ?? new Payment_DescriptionManager(new Payment_DescriptionDal()); }
        }
    }
}
