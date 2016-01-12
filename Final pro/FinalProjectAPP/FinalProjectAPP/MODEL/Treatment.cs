using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectAPP.MODEL
{
    [Serializable()]
    public class Treatment
    {
        public int Id { get; set; }
        public int DiseaseId { get; set; }
        public string PatientId { get; set; }
        public int MedicineId { get; set; }
        public int MedicineQty { get; set; }
        public string Dose { get; set; }
        public string BeforeAfter { get; set; }
        public string Note { get; set; }
        public string Date { get; set; }
        public int Count { get; set; }
        public int CenterId { get; set; }

    }
}