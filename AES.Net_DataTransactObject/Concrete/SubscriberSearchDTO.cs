using AES.Net_CoreLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AES.Net_DataTransactObject.Concrete
{
    public class SubscriberSearchDTO:IDTO
    {
        public string SUBID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string CODE_1 { get; set; }
        public string CONTACT { get; set; }
        public string RayonID { get; set; }
        public string SUBJECTNAME { get; set; }
        public string MatrixID { get; set; }
        public string MATRIXNAME { get; set; }
        public string KUCE { get; set; }
        public string STREETNAME { get; set; }
        public string Bina { get; set; }
        public string Menzil { get; set; }
    }
}
