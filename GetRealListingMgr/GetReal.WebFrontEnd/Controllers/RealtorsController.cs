using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetReal.Model;
using GetReal.Service;
using GetReal.WebFrontEnd.Models;

namespace GetReal.WebFrontEnd.Controllers
{
    public class RealtorsController : Controller
    {
        private RealtorService realtorService = new RealtorService();

        // GET: Realtors
        public ActionResult Index()
        {
            return View(realtorService.GetRealtorList());
        }

        public ActionResult Create()
        {
            RealtorAddEditVM vm = new RealtorAddEditVM()
            {
                Realtor = new Realtor()
                {
                    StartDate = DateTime.Now
                },
                Companies = new LookupService().GetAllCompanies().Select(c => new SelectListItem
                {
                    Value = c.CompanyId.ToString(),
                    Text = c.CompanyName
                }).ToList()
            };
            return View(vm);
        }
    }
}