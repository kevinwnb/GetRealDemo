using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetReal.Model;
using GetReal.Repository;

namespace GetReal.Service
{
    public class LookupService
    {
        private LookupsRepo repo = new LookupsRepo();
        public List<CompanyLookup> GetAllCompanies()
        {
            return repo.GetAllCompanies();
        }
    }
}
