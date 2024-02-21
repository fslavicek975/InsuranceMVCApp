using System.ComponentModel.DataAnnotations;

namespace InsuranceMVCApp.Models
{
    public class Policy
    {
        [Required(ErrorMessage = "Policy number is required.")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Policy number must be between 10 and 15 characters.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Policy number must be alphanumeric.")]
        public string PolicyNumber { get; set; }

        
        [Required(ErrorMessage = "Policy amount is required.")]
        public decimal PolicyAmount { get; set; }

        public int PartnerId { get; set; }
    }
}
