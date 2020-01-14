using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetReal.Model;
using DAL;
using System.Data;
using Types;

namespace GetReal.Repository
{
    public class RealtorRepo
    {
        public List<RealtorList> GetAll()
        {
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Realtor_GetAll");

            List<RealtorList> realtors = new List<RealtorList>();

            foreach (DataRow row in dt.Rows)
            {
                realtors.Add(new RealtorList()
                {
                    RealtorId = Convert.ToInt32(row["RealtorId"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    CompanyName = row["CompanyName"].ToString(),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    CommissionRate = Convert.ToDouble(row["CommissionRate"])
                });
            }

            return realtors;
        }

        public bool Add(Realtor r)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@FirstName", r.FirstName, SqlDbType.NVarChar, 20));
            parms.Add(new ParmStruct("@LastName", r.LastName, SqlDbType.NVarChar, 30));
            parms.Add(new ParmStruct("@CompanyId", r.CompanyId, SqlDbType.Int));
            parms.Add(new ParmStruct("@StartDate", r.StartDate, SqlDbType.DateTime2));
            parms.Add(new ParmStruct("@CommissionRate", r.CommissionRate, SqlDbType.Decimal));

            return new DataAccess().ExecuteNonQuery("Realtor_Insert", CommandType.StoredProcedure, parms) > 0;
        }
    }
}
