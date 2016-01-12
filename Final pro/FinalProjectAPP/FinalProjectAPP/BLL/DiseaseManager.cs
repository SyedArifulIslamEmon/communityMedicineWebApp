using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using FinalProjectAPP.DAL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.BLL
{
    public class DiseaseManager
    {
        DiseaseGateway aDiseaseGateway = new DiseaseGateway();
        public string Insert(Disease aDisease)
        {
            if (aDisease.Name == "")
            {
                return "Enter a Name";
            }
            else if (aDiseaseGateway.Cheak(aDisease.Name)==true)
            {
                return "Already Exist.";
            }
            else if (aDiseaseGateway.Insert(aDisease)>0)
                return "Medicine Saved";
            else
                return "Try Again";
        }

        public DataTable GetAllDisease()
        {
            return aDiseaseGateway.GetAllDisease();
        }

        public int GetDiseaseId(string name)
        {
           return aDiseaseGateway.GetDiseaseId(name);
        }
    }
}