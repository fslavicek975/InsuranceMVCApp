using System;

namespace InsuranceMVCApp.Models
{
    public class AllDetails
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PartnerNumber { get; set; }

        public string CroatianPIN { get; set; }

        public int PartnerTypeId { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public string CreateByUser { get; set; }

        public bool IsForeign { get; set; }

        public string ExternalCode { get; set; }

        public string Gender { get; set; }

        public string PolicyNumber { get; set; }

        public decimal PolicyAmount { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } set { } }

    }
}