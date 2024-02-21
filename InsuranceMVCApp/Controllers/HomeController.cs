using DataLibrary.BusinessLogic;
using InsuranceMVCApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceMVCApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult ViewPartners()
        {
            ViewBag.Message = "Partners List";

            var data = PartnerProcessor.LoadPartners();

            List<Partner> partners = new List<Partner>();

            foreach (var row in data)
            {
                partners.Add(new Partner
                {
                    Id = row.Id,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Address = row.Address,
                    PartnerNumber = row.PartnerNumber,
                    CroatianPIN = row.CroatianPIN,
                    PartnerTypeId = row.PartnerTypeId,
                    CreateByUser = row.CreateByUser,
                    IsForeign = row.IsForeign,
                    ExternalCode = row.ExternalCode,
                    Gender = row.Gender,
                    CreatedAtUtc = row.CreatedAtUtc
                });
            }

            return View(partners);
        }

        public ActionResult Details(int id)
        {
            var data = PartnerProcessor.LoadDetails(id);

            List<AllDetails> details = new List<AllDetails>();

            foreach (var row in data)
            {
                details.Add(new AllDetails
                {

                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Address = row.Address,
                    PartnerNumber = row.PartnerNumber,
                    CroatianPIN = row.CroatianPIN,
                    PartnerTypeId = row.PartnerTypeId,
                    CreateByUser = row.CreateByUser,
                    IsForeign = row.IsForeign,
                    ExternalCode = row.ExternalCode,
                    Gender = row.Gender,
                    CreatedAtUtc = row.CreatedAtUtc,
                    PolicyNumber = row.PolicyNumber,
                    PolicyAmount = row.PolicyAmount
                });
            }

            return View(details);
        }



        public ActionResult AddNewPartner(Partner model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = PartnerProcessor.CreatePartner(model.FirstName, model.LastName, model.Address, model.PartnerNumber,
                    model.CroatianPIN, model.PartnerTypeId, model.CreateByUser, model.IsForeign,
                    model.ExternalCode, model.Gender);

                return RedirectToAction("ViewPartners");
            }

            return View();
        }

        public ActionResult AddNewPolicy(Policy model, int id)
        {
            var PartnerId = PartnerProcessor.LoadPartners().Where(x => x.Id == id).Select(x => x.Id).FirstOrDefault();
            if (ModelState.IsValid)
            {
                int recordsCreated = PolicyProcessor.CreatePolicy(model.PolicyNumber, model.PolicyAmount, PartnerId);
                return RedirectToAction("ViewPartners");
            }

            return View();
        }
    }
}