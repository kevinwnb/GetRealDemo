using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using GetReal.Model;

namespace GetReal.Repository
{
    public class LookupsRepo
    {
        public List<CompanyLookup> GetAllCompanies()
        {
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Company_Lookup");

            List<CompanyLookup> companies = new List<CompanyLookup>();

            foreach (DataRow row in dt.Rows)
            {
                companies.Add(new CompanyLookup()
                {
                    CompanyId = Convert.ToInt32(row["CompanyId"]),
                    CompanyName = row["CompanyName"].ToString()
                });
            }

            return companies;
        }
    }
}
