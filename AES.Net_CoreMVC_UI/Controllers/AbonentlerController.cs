using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AES.Net_BusinessLogicalLayer.UnitOfWork;
using AES.Net_CoreMVC_UI.Models;
using AES.Net_DataAccessLayer.Concrete.Ado.Net;
using AES.Net_DataTransactObject.Concrete;
using AES.Net_Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AES.Net_CoreMVC_UI.Controllers
{
    public class AbonentlerController : Controller
    {
        private IUnitOfWork unitOfWork;
        public AbonentlerController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            var model = new AbonentIndexModel()
            {
                Tarifs = unitOfWork.tarifService.GetAll(),
                Sahes = unitOfWork.saheService.GetAll(),
                Qesebes = unitOfWork.qesebeService.GetAll(),
                Statuses = unitOfWork.statusService.GetAll(),
                PersonelIdSeqs = unitOfWork.personelIdSeqService.GetAll(),
                Subjects = unitOfWork.subjectService.GetAll(),
                SubscriberSearches = unitOfWork.subscriberService.GetSubscriberSearchDTOs(),
                Accept_Payments = unitOfWork.accept_PaymentService.GetAll(),
                MenzilTipis = unitOfWork.menzilTipiService.GetAll(),
            };

            return View(model);
        }

        public IActionResult SendOptionsWithID(string id)
        {
            var model = new AbonentIndexModel()
            {
                Matrices = unitOfWork.matrixService.GetAllWithID(id)
            };
            return PartialView(model);
        }

        public IActionResult GETSTREETS(string id)
        {
            var model = new AbonentIndexModel()
            {
                Streets = unitOfWork.streetService.GetAllWithID(id)
            };
            return PartialView(model);
        }

        public IActionResult GETSTREETSWithSubjectİD(string id)
        {
            var model = new AbonentIndexModel()
            {
                Streets = unitOfWork.streetService.GetAllWithID(id)
            };
            return PartialView(model);
        }

        public IActionResult AddSubscriber(SubscriberAddDTO subscriber)
        {
            if (subscriber.SUBID != null)
            {
                bool result = unitOfWork.subscriberService.Update(subscriber);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                bool result = unitOfWork.subscriberService.Add(subscriber);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

        }

        public IActionResult GETSUBSCRIBER(string id)
        {
            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(id);

            Subscriber subsciriber = subscribers[0];

            string seherID = subsciriber.SUBID.Substring(0, 2);
            string matrixID = subsciriber.SUBID.Substring(2, 2);
            string kuceID = subsciriber.SUBID.Substring(4, 3);
            string binaID = subsciriber.SUBID.Substring(7, 4);
            string evID = subsciriber.SUBID.Substring(11, 4);

            var model = new AbonentIndexModel()
            {
                Tarifs = unitOfWork.tarifService.GetAll(),
                Sahes = unitOfWork.saheService.GetAll(),
                Qesebes = unitOfWork.qesebeService.GetAll(),
                Statuses = unitOfWork.statusService.GetAll(),
                PersonelIdSeqs = unitOfWork.personelIdSeqService.GetAll(),
                Subscriber = subsciriber,
                Subjects = unitOfWork.subjectService.GetAll(),
                Matrices = unitOfWork.matrixService.GetAllWithID(seherID),
                Streets = unitOfWork.streetService.GetAllWithID(kuceID),
                SubscriberSearches = unitOfWork.subscriberService.GetSubscriberSearchDTOs(),
                Accept_Payments = unitOfWork.accept_PaymentService.GetAll(),
                MenzilTipis = unitOfWork.menzilTipiService.GetAll()
            };

            ViewBag.seherID = seherID;
            ViewBag.matrixID = matrixID;
            ViewBag.kuceID = kuceID;
            ViewBag.binaID = binaID;
            ViewBag.evID = evID;

            List<Status> status = unitOfWork.statusService.GetAllWithID(subsciriber.STATUS);
            List<PersonelIdSeq> personelIdSeqs = unitOfWork.personelIdSeqService.GetAllWithID(subsciriber.PERSONAL_ID_SEQ);
            List<Accept_Payment> accept_Payments = unitOfWork.accept_PaymentService.GetAllWithID(subsciriber.ACCEPT_PAYMENTS);
            List<MenzilTipi> menzilTipis = unitOfWork.menzilTipiService.GetAllWithID(subsciriber.BUILDING_ID_SEQ);

            ViewBag.status = status[0].ID;
            ViewBag.personel = personelIdSeqs[0].ID;
            ViewBag.acceptPayment = accept_Payments[0].ID;
            ViewBag.menzilTipi = menzilTipis[0].ID;
            return PartialView(model);
        }

        public IActionResult GETSUBSCRIBERBySUBID(string id)
        {
            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(id);

            Subscriber subsciriber = subscribers[0];

            string seherID = subsciriber.SUBID.Substring(0, 2);
            string matrixID = subsciriber.SUBID.Substring(2, 2);
            string kuceID = subsciriber.SUBID.Substring(4, 3);
            string binaID = subsciriber.SUBID.Substring(7, 4);
            string evID = subsciriber.SUBID.Substring(11, 4);

            var model = new AbonentIndexModel()
            {
                Tarifs = unitOfWork.tarifService.GetAll(),
                Sahes = unitOfWork.saheService.GetAll(),
                Qesebes = unitOfWork.qesebeService.GetAll(),
                Statuses = unitOfWork.statusService.GetAll(),
                PersonelIdSeqs = unitOfWork.personelIdSeqService.GetAll(),
                Subscriber = subsciriber,
                Subjects = unitOfWork.subjectService.GetAll(),
                Matrices = unitOfWork.matrixService.GetAllWithID(seherID),
                Streets = unitOfWork.streetService.GetAllWithID(matrixID),
                SubscriberSearches = unitOfWork.subscriberService.GetSubscriberSearchDTOs(),
                Accept_Payments = unitOfWork.accept_PaymentService.GetAll(),
                MenzilTipis = unitOfWork.menzilTipiService.GetAll()
            };

            ViewBag.seherID = seherID;
            ViewBag.matrixID = matrixID;
            ViewBag.kuceID = kuceID;
            ViewBag.binaID = binaID;
            ViewBag.evID = evID;

            List<Status> status = unitOfWork.statusService.GetAllWithID(subsciriber.STATUS);
            List<PersonelIdSeq> personelIdSeqs = unitOfWork.personelIdSeqService.GetAllWithID(subsciriber.PERSONAL_ID_SEQ);
            List<Accept_Payment> accept_Payments = unitOfWork.accept_PaymentService.GetAllWithID(subsciriber.ACCEPT_PAYMENTS);
            List<MenzilTipi> menzilTipis = unitOfWork.menzilTipiService.GetAllWithID(subsciriber.BUILDING_ID_SEQ);


            ViewBag.status = status[0].ID;
            ViewBag.personel = personelIdSeqs[0].ID;
            ViewBag.acceptPayment = accept_Payments[0].ID;
            ViewBag.menzilTipi = menzilTipis[0].ID;

            return View("GETSUBSCRIBERWithSUBIDControllerView", model);
        }
        public IActionResult DeleteSubscriber(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                bool result = unitOfWork.subscriberService.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

        }

        public IActionResult GetSubscriberWithSUBID(string id)
        {
            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(id);
            List<SubscriberSearchDTO> SubscriberSearches = unitOfWork.subscriberService.GetSubscriberSearchDTOEntitiy(id);

            var model = new AbonentIndexModel()
            {
                Subscribers = subscribers,
                Subscriber = subscribers[0],
                Subjects = unitOfWork.subjectService.GetAll(),
                SubscriberSearchDTOEntity = SubscriberSearches[0],
                SubscriberSearches = SubscriberSearches
            };

            return PartialView(model);
        }





        public IActionResult Payments(string id)
        {
            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(id);

            var model = new AbonentOdemeModel()
            {
                Subscriber = subscribers[0],
                Payments = unitOfWork.paymentService.GetAllWithSUBID(id),
                Payment_Descriptions = unitOfWork.payment_DescriptionService.GetAll()
            };

            return View("GetAllPayments", model);
        }

        public IActionResult AddPayment(Payment payment)
        {
            var result = unitOfWork.paymentService.Add(payment);

            return RedirectToAction("Payments", new { id = payment.SUBID });
        }

        public IActionResult UpdatePayment(AbonentUpdatePaymentModel updatePayment)
        {
            Payment payment = new Payment();
            payment.SUBID = updatePayment.SUBID;
            payment.FORM_OF_PAYMENT = updatePayment.FORM_OF_PAYMENT;
            payment.DDATE = updatePayment.DDATE;
            payment.CHARGE = updatePayment.CHARGE;

            var result = unitOfWork.paymentService.UpdatePayment(payment, updatePayment.old_DDATE);

            return RedirectToAction("Payments", new { id = payment.SUBID });
        }

        public IActionResult GetPayment(string id)
        {
            string[] subs = id.Split('a');
            string SUBID = subs[0];
            DateTime DDATE = Convert.ToDateTime(subs[1]);
            int CHARGE = Convert.ToInt32(subs[2]);
            string FORM_OF_PAYMENT = subs[3];

            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(SUBID);
            List<Payment> payments = unitOfWork.paymentService.GetAllWithID(SUBID, DDATE, CHARGE, FORM_OF_PAYMENT);

            var model = new AbonentOdemeModel()
            {
                Subscriber = subscribers[0],
                Payments = unitOfWork.paymentService.GetAllWithSUBID(SUBID),
                Payment = payments[0],
                Payment_Descriptions = unitOfWork.payment_DescriptionService.GetAll()
            };
            ViewBag.payment_Description = payments[0].FORM_OF_PAYMENT;
            return View(model);
        }

        public IActionResult DeletePayment(string id)
        {
            string[] subs = id.Split('a');
            string SUBID = subs[0];
            DateTime DDATE = Convert.ToDateTime(subs[1]);
            int CHARGE = Convert.ToInt32(subs[2]);
            var result = unitOfWork.paymentService.Delete(SUBID, DDATE, CHARGE);

            return RedirectToAction("Payments", new { id = SUBID });
        }

        public IActionResult Subcontrol(string id)
        {
            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(id);

            var model = new AbonentGostericiModel()
            {
                SubscribeSUBID = id,
                Submeters = unitOfWork.subcontrolService.GetAllWithID(id),
                PersonelIdSeqs = unitOfWork.personelIdSeqService.GetAll()
            };

            return View("SubcontrolWithSUBID", model);
        }

        public IActionResult GetSubcontrol(string id)
        {
            string[] subs = id.Split('a');
            string SUBID = subs[0];
            DateTime DDATE = Convert.ToDateTime(subs[1]);

            List<Subscriber> subscribers = unitOfWork.subscriberService.GetAllWithID(SUBID);
            List<Subcontrol> subcontrols = unitOfWork.subcontrolService.GetSubcontrol(SUBID, DDATE);

            var model = new AbonentGostericiModel()
            {
                SubscribeSUBID = SUBID,
                Submeters = unitOfWork.subcontrolService.GetSubcontrol(SUBID, DDATE),
                PersonelIdSeqs = unitOfWork.personelIdSeqService.GetAll(),
                Submeter=subcontrols[0]
            };
            ViewBag.Personel = subcontrols[0].PERSONEL_ID_SEQ;

            return View( model);
        }

        [HttpPost]
        public IActionResult AddSubcontrol(Subcontrol subcontrol)
        {
            subcontrol.VERIFIED_CH = "1";
            var result = unitOfWork.subcontrolService.Add(subcontrol);

            var model = new AbonentGostericiModel()
            {
                SubscribeSUBID = subcontrol.SUBID,
                Submeters = unitOfWork.subcontrolService.GetAllWithID(subcontrol.SUBID)
            };
            return RedirectToAction("Subcontrol",new { id=subcontrol.SUBID});
        }

        public IActionResult UpdateSubcontrol(AbonentUpdateSubcontrolModel subcontrolModel)
        {
            Subcontrol subcontrol = new Subcontrol();
            subcontrol.DDATE = subcontrolModel.DDATE;
            subcontrol.FARE = subcontrolModel.FARE;
            subcontrol.METERVALUE = subcontrolModel.METERVALUE;
            if (subcontrolModel.PERSONEL_ID_SEQ==0)
            {
                subcontrol.PERSONEL_ID_SEQ = subcontrolModel.old_PERSONEL_ID_SEQ;
            }
            else
            {
                subcontrol.PERSONEL_ID_SEQ = subcontrolModel.PERSONEL_ID_SEQ;
            }
            subcontrol.R_FARE = subcontrolModel.R_FARE;
            subcontrol.R_METERVALUE = subcontrolModel.R_METERVALUE;
            subcontrol.SUBID = subcontrolModel.SUBID;
            subcontrol.VAT_PERCENT = subcontrolModel.VAT_PERCENT;
            subcontrol.VERIFIED_CH = subcontrolModel.VERIFIED_CH;

            var result = unitOfWork.subcontrolService.UpdateSubcontrol(subcontrol, subcontrolModel.old_DDATE);

            return RedirectToAction("Subcontrol", new { id = subcontrolModel.SUBID });
        }

        public IActionResult DeleteSubcontrol(string id)
        {
            string[] subs = id.Split('a');
            string SUBID = subs[0];
            int meterValue=Convert.ToInt32(subs[1]);

            var result = unitOfWork.subcontrolService.Delete(meterValue);

            return RedirectToAction("Subcontrol", new { id = SUBID });
        }
    }
}
