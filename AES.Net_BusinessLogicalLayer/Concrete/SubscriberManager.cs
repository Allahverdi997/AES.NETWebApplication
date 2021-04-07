using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_DataTransactObject.Concrete;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AES.Net_BusinessLogicalLayer.Concrete
{
    public class SubscriberManager : ISubscriberService
    {
        private ISubscriberDal subscriberDal;
        public SubscriberManager(ISubscriberDal _subscriberDal)
        {
            subscriberDal = _subscriberDal;
        }
        public bool Add(SubscriberAddDTO entity)
        {
            Subscriber subscriber = new Subscriber();

            subscriber.ACCEPT_PAYMENTS = entity.ACCEPT_PAYMENTS;
            subscriber.BUILDING_ID_SEQ = entity.BUILDING_ID_SEQ;
            subscriber.CODE1_BR1 = entity.CODE1_BR1;
            subscriber.CODE1_BR2=entity.CODE1_BR2;
            subscriber.CODE1_BR3= entity.CODE1_BR3;
            subscriber.CODE_1= entity.CODE_1;
            subscriber.CODE_2= entity.CODE_2;
            subscriber.CODE_3= entity.CODE_3;
            subscriber.CODE_BR1= entity.CODE_BR1;
            subscriber.CODE_BR2= entity.CODE_BR2;
            subscriber.CODE_BR3= entity.CODE_BR3;
            subscriber.CONTACT= entity.CONTACT;
            subscriber.CONTRACT_NO= entity.CONTRACT_NO;
            subscriber.CUSTOMER_ID_SEQ= entity.CUSTOMER_ID_SEQ;
            subscriber.DEBET= entity.DEBET;
            subscriber.DEBETKVTH= entity.DEBETKVTH;
            subscriber.DEBETDATE = entity.DEBETDATE;
            subscriber.DEGREE= entity.DEGREE;
            subscriber.ENDDATE= entity.ENDDATE;
            subscriber.HAVE_SIBLINGS_CH= "12";
            subscriber.HOMEAREA= entity.HOMEAREA;
            subscriber.HOUSE = entity.HOUSE;
            subscriber.LASTMODDATE = DateTime.Now;
            subscriber.MIDDLENAME= entity.MIDDLENAME;
            subscriber.NAME= entity.NAME;
            if (entity.NO_METER_CH=="on")
            {
                subscriber.NO_METER_CH = "1";
            }
            else if (entity.NO_METER_CH == "off")
            {
                subscriber.NO_METER_CH = "0";
            }
            subscriber.NO_METER_KWTH= entity.NO_METER_KWTH;
            subscriber.OLD_SUBID = entity.RayonID + entity.MatrixID + entity.KUCE + entity.BinaID + entity.MenzilID;
            subscriber.PERSONAL_ID_SEQ= entity.PERSONAL_ID_SEQ;
            subscriber.POSTID= entity.POSTID;
            subscriber.PSPT_DATE= entity.PSPT_DATE;
            subscriber.PSPT_NO= entity.PSPT_NO;
            subscriber.PSPT_NOTE = "12";
            subscriber.PSPT_SER= entity.PSPT_SER;
            subscriber.REGDATE= entity.REGDATE;
            subscriber.REMARK = "12";
            subscriber.STATUS = entity.STATUS;
            subscriber.SUBID = entity.RayonID + entity.MatrixID + entity.KUCE + entity.BinaID + entity.MenzilID;
            subscriber.SURNAME= entity.SURNAME;
            subscriber.S_ID_SEQ= entity.S_ID_SEQ;

            return subscriberDal.Add(subscriber);
        }

        public bool Delete(string id)
        {
            return subscriberDal.Delete(id);
        }

        public List<Subscriber> GetAll()
        {
            return subscriberDal.GetAll();
        }

        public List<Subscriber> GetAllWithID(object id)
        {
            return subscriberDal.GetAllWithID(id);
        }

        public List<SubscriberSearchDTO> GetSubscriberSearchDTOs()
        {
            return subscriberDal.GetSubscriberSearchDTOs();
        }

        public bool Update(SubscriberAddDTO entity)
        {
            Subscriber subscriber = new Subscriber();

            subscriber.ACCEPT_PAYMENTS = entity.ACCEPT_PAYMENTS;
            subscriber.BUILDING_ID_SEQ = entity.BUILDING_ID_SEQ;
            subscriber.CODE1_BR1 = entity.CODE1_BR1;
            subscriber.CODE1_BR2 = entity.CODE1_BR2;
            subscriber.CODE1_BR3 = entity.CODE1_BR3;
            subscriber.CODE_1 = entity.CODE_1;
            subscriber.CODE_2 = entity.CODE_2;
            subscriber.CODE_3 = entity.CODE_3;
            subscriber.CODE_BR1 = entity.CODE_BR1;
            subscriber.CODE_BR2 = entity.CODE_BR2;
            subscriber.CODE_BR3 = entity.CODE_BR3;
            subscriber.CONTACT = entity.CONTACT;
            subscriber.CONTRACT_NO = entity.CONTRACT_NO;
            subscriber.CUSTOMER_ID_SEQ = entity.CUSTOMER_ID_SEQ;
            subscriber.DEBET = entity.DEBET;
            subscriber.DEBETDATE = entity.DEBETDATE;
            subscriber.DEBETKVTH = entity.DEBETKVTH;
            subscriber.DEGREE = entity.DEGREE;
            subscriber.ENDDATE = entity.ENDDATE;
            subscriber.HAVE_SIBLINGS_CH = "12";
            subscriber.HOMEAREA = entity.HOMEAREA;
            subscriber.HOUSE = entity.HOUSE;
            subscriber.LASTMODDATE = DateTime.Now;
            subscriber.MIDDLENAME = entity.MIDDLENAME;
            subscriber.NAME = entity.NAME;
            if (entity.NO_METER_CH == "on")
            {
                subscriber.NO_METER_CH = "1";
            }
            else if (entity.NO_METER_CH == "off")
            {
                subscriber.NO_METER_CH = "0";
            }
            subscriber.NO_METER_KWTH = entity.NO_METER_KWTH;
            subscriber.OLD_SUBID = entity.OLD_SUBID;
            subscriber.PERSONAL_ID_SEQ = entity.PERSONAL_ID_SEQ;
            subscriber.POSTID = entity.POSTID;
            subscriber.PSPT_DATE = entity.PSPT_DATE;
            subscriber.PSPT_NO = entity.PSPT_NO;
            subscriber.PSPT_NOTE = "12";
            subscriber.PSPT_SER = entity.PSPT_SER;
            subscriber.REGDATE = entity.REGDATE;
            subscriber.REMARK = "12";
            subscriber.STATUS = entity.STATUS;
            subscriber.SUBID = entity.RayonID + entity.MatrixID + entity.KUCE + entity.BinaID + entity.MenzilID;
            subscriber.SURNAME = entity.SURNAME;
            subscriber.S_ID_SEQ = entity.S_ID_SEQ;

            return subscriberDal.Update(subscriber);
        }

        public List<SubscriberSearchDTO> GetSubscriberSearchDTOEntitiy(string id)
        {
            return subscriberDal.GetSubscriberSearchDTOEntitiy(id);
        }
    }
}
