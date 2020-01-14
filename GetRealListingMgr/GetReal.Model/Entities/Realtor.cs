using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GetReal.Model
{
    public class Realtor : BaseEntity
    {
        public int RealtorId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(20, ErrorMessage = "First Name can only be 20 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(30, ErrorMessage = "Last Name can only be 20 characters.")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        [Required(ErrorMessage = "Company is required.")]
        public int CompanyId { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Start Date is required.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Commission Rate")]
        [Required(ErrorMessage = "Commission Rate is required.")]
        public double CommissionRate { get; set; }
    }
}
