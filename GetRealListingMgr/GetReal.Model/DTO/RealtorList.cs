using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GetReal.Model
{
    public class RealtorList
    {
        public int RealtorId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        public string CompanyName { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        public DateTime StartDate { get; set; }
        public double CommissionRate { get; set; }
    }
}
