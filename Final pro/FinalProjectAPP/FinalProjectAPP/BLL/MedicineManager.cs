using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using FinalProjectAPP.DAL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.BLL
{
    public class MedicineManager
    {
        MedicineGateway aMedicineGateway =new MedicineGateway();

        public string Insert(Medicine aMedicine)
        {
            if (aMedicine.Name == "")
            {
                return "Enter A name";
            }
            else if (aMedicineGateway.Check(aMedicine.Name) == true)
            {
                return "Already Exist";
            }
          
            else if (aMedicineGateway.Insert(aMedicine) > 0)
                return "Medicine Saved";
            else
                return "Try Again";
        }

        public DataTable GetAllMedicine()
        {
            return aMedicineGateway.GetAllMedicine();
        }

        public List<string> GetMedicineList()
        {
            return aMedicineGateway.GetMedicineList();
        }

        public int GetMedicineIdByName(string name)
        {
            return aMedicineGateway.GetMedicineIdByName(name);
        }

        public string GetMedicineNambeById(int id)
        {
            return aMedicineGateway.GetMedicineNambeById(id);
        }


    }
}