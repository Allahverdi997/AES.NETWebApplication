using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Subscriber:IEntity
    { 
        #nullable enable
        public string SUBID { get; set; }
        public int S_ID_SEQ { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string CONTACT { get; set; }
        public double HOMEAREA { get; set; }
        [DataType(DataType.Text)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{dd.mm.yyyy}")]
        public DateTime REGDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public string STATUS { get; set; }
        public double DEBET { get; set; }
        public double DEBETKVTH { get; set; }
        public DateTime DEBETDATE { get; set; }
        public string OLD_SUBID { get; set; }
        public string REMARK { get; set; }
        public string PSPT_SER { get; set; }
        public string PSPT_NO { get; set; }
        public string PSPT_NOTE { get; set; }
        public DateTime PSPT_DATE { get; set; }
        public DateTime LASTMODDATE { get; set; }
        public int POSTID { get; set; }
        public string NO_METER_CH { get; set; }
        public int NO_METER_KWTH { get; set; }
        public int CUSTOMER_ID_SEQ { get; set; }
        public string CONTRACT_NO { get; set; }
        public string HAVE_SIBLINGS_CH { get; set; }
        public int CODE_1 { get; set; }
        public int CODE_2 { get; set; }
        public int CODE_3 { get; set; }
        public int CODE_BR1 { get; set; }
        public int CODE_BR2 { get; set; }
        public int CODE_BR3 { get; set; }
        public int CODE1_BR1 { get; set; }
        public int CODE1_BR2 { get; set; }
        public int CODE1_BR3 { get; set; }
        public int DEGREE { get; set; }
        public string ACCEPT_PAYMENTS { get; set; }
        public int PERSONAL_ID_SEQ { get; set; }
        public int BUILDING_ID_SEQ { get; set; }
        public string HOUSE { get; set; }

    }
}
