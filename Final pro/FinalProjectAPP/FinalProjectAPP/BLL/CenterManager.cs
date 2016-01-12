using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectAPP.DAL;
using FinalProjectAPP.MODEL;

namespace FinalProjectAPP.BLL
{
    public class CenterManager
    {
        CenterGateway aCenterGateway = new CenterGateway();

        public string Insert(Center aCenter)
        {
            if (aCenter.Name == "")
            {
                return "Enter A Center Name";
            }
            else if (aCenterGateway.Cheak(aCenter.Name,aCenter.ThanaId)==true)
            {
                return "Already Exist ";
            }
            else if (aCenterGateway.Insert(aCenter) > 0)
                return "Saved";
            else
                return "Try Again";
        }
        

        public int GetTotalThana(int thanaId)
        {
            return aCenterGateway.GetTotalCenter(thanaId);
        }

        public List<string> GetCenterList(int id)
        {
            return aCenterGateway.GetCenterList(id);
        }

        public int GetCenterId(string name,int mode)
        {
            return aCenterGateway.GetCenterId(name,mode);
        }

        public bool AuthenticateCenterLogin(string code, string password)
        {
            if (password == aCenterGateway.AuthenticateCenterLogin(code))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> GetCenterListByThanaID(int thanaId)
        {
            return aCenterGateway.GetCenterListByThanaID(thanaId);
        }
    }
}