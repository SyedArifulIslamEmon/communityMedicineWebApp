using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProjectAPP.DAL;

namespace FinalProjectAPP.BLL
{
    public class DistrictThanaManager
    {
        DistrictThanaGetway aDistrictThanaGetway = new DistrictThanaGetway();
        public List<string> GetDistrictList()
        {
            return aDistrictThanaGetway.GetDistrictList();
        }

        public List<string> GetThanaList(int id)
        {
            return aDistrictThanaGetway.GetThanaList(id);
        }

        public int GetDistrictId(string name)
        {
            return aDistrictThanaGetway.GetDistrictId(name);
        }

        public int GetThanaId(string name)
        {
            return aDistrictThanaGetway.GetThanaId(name);
        }

        public List<int> GetThanaIDList(int id)
        {
            return aDistrictThanaGetway.GetThanaIDList(id);
        }

        public int GetPopulation(int id)
        {
            return aDistrictThanaGetway.GetPopulation(id);
        }
    }
}