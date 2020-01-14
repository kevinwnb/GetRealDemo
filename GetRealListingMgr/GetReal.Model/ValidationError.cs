using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReal.Model
{
    public class ValidationError
    {
        public ValidationError(string errDesc)
        {
            ErrorDescription = errDesc;
        }

        public ValidationError(string errNum, string errName, string errDesc)
        {
            ErrorNumber = errNum;
            ErrorName = errName;
            ErrorDescription = errDesc;
        }

        public string ErrorNumber { get; set; }
        public string ErrorName { get; set; }
        public string ErrorDescription { get; set; }
    }
}
