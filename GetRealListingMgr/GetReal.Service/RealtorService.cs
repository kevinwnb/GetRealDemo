using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetReal.Repository;
using GetReal.Model;

namespace GetReal.Service
{
    public class RealtorService
    {
        private RealtorRepo realtorRepo = new RealtorRepo();

        public List<RealtorList> GetRealtorList()
        {
            return realtorRepo.GetAll();
        }

        public bool AddRealtor(Realtor realtorToAdd)
        {
            // We will add the validation here eventually
            return realtorRepo.Add(realtorToAdd);
        }
    }
}
