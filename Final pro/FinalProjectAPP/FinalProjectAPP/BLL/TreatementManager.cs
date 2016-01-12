using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using FinalProjectAPP.DAL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.BLL
{
    public class TreatementManager
    {
        TreatementGateway aTreatementGateway = new TreatementGateway();
        public void Insert(Treatment aTreatment)
        {
            aTreatementGateway.Insert(aTreatment);
        }

        public int GetTreatementCount(string patientId)
        {
            return aTreatementGateway.GetTreatementCount(patientId);
        }

        public int GetTotalByCenterDisease(int centerId, int diseaseId, string d1, string d2)
        {
           return aTreatementGateway.GetTotalByCenterDisease(centerId, diseaseId, d1 , d2);
        }

        public List<int> GetCenterList(int diseaseId, string d1, string d2)
        {
            return aTreatementGateway.GetCenterList(diseaseId, d1, d2);
        }
    }
}