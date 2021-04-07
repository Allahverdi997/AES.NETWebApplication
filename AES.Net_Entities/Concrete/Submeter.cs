using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_Entities.Concrete
{
    public class Submeter:IEntity
    {
        public string SUBID { get; set; }
        public string METERID { get; set; }
        public DateTime DDATE { get; set; }
        public string METERNO { get; set; }
        public int FIRSTSHOW { get; set; }
        public int R_FIRSTSHOW { get; set; }
        public int R_COS { get; set; }
        public string REACTIVE_CH { get; set; }
        public int TRANSCOEF { get; set; }
        public int PERSONNEL_ID_SEQ { get; set; }
    }
}
