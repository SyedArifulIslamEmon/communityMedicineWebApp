using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectAPP.DAL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.BLL
{
    public class DoctorManager
    {
        DoctorGateway aDoctorGateway = new DoctorGateway();
        public string Insert(Doctor aDoctor)
        {
            if (aDoctor.Name == "")
            {
                return "Enter A Center Name";
            }
            else if (aDoctorGateway.Insert(aDoctor) > 0)
                return "Saved";
            else
                return "Try Again";
        }

        public List<string> GetDoctorList(int id)
        {
            return aDoctorGateway.GetDoctorList(id);
        }
    }
}