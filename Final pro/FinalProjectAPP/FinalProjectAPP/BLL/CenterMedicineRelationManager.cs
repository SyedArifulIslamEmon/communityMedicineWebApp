using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using FinalProjectAPP.DAL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.BLL
{
    public class CenterMedicineRelationManager
    {
        CenterMedicineRelationGetway aCenterMedicineRelationGetway = new CenterMedicineRelationGetway();
        public void Insert(CenterMedicineRelation aCenterMedicineRelation)
        {
             aCenterMedicineRelationGetway.Insert(aCenterMedicineRelation);
        }

        public void UpdateMedicine(CenterMedicineRelation aCenterMedicineRelation)
        {
            aCenterMedicineRelationGetway.UpdateMedicine(aCenterMedicineRelation);
        }

        public List<int> GetMedicinListByCenterID(int id)
        {
            return aCenterMedicineRelationGetway.GetMedicinListByCenterID(id);
        }

        public bool IsExist(CenterMedicineRelation aCenterMedicineRelation)
        {
            return aCenterMedicineRelationGetway.IsExist(aCenterMedicineRelation);
        }

        public void AddMedicine(CenterMedicineRelation aCenterMedicineRelation)
        {
            aCenterMedicineRelationGetway.AddMedicine(aCenterMedicineRelation);
        }

        public int GetMedicineQty(int centerId, int medicineId)
        {
           return aCenterMedicineRelationGetway.GetMedicineQty(centerId, medicineId);
        }

        public DataTable GetStockMedicine(int id)
        {
            return aCenterMedicineRelationGetway.GetStockMedicine(id);
        }
    }

}