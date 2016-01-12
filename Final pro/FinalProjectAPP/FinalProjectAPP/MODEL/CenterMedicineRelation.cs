using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectAPP.MODEL
{
    public class CenterMedicineRelation
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public int MedicineId { get; set; }
        public int MedicineQuantity { get; set; }
        public string Date { get; set; }
    }
}