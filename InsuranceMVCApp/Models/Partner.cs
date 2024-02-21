using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceMVCApp.Models
{
    public class Partner //ovo su fronend modeli, bussiness logic data acces modeli su u DataLibrary
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 255 characters.")]
        [RegularExpression("^[a-zA-Z0-9ćčžšđĆČŽŠĐ ]*$", ErrorMessage = "First name must be alphanumeric.")]
        public string FirstName { get; set; }

       
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 255 characters.")]
        [RegularExpression("^[a-zA-Z0-9ćčžšđĆČŽŠĐ ]*$", ErrorMessage = "Last name must be alphanumeric.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Address name is required.")]
        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string Address { get; set; }

        
        [Required(ErrorMessage = "Partner number is required. Partner number must be exactly 20 digits.")]
        [StringLength(20, MinimumLength = 20, ErrorMessage = "Partner number must be exactly 20 digits.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Partner number must be numeric.")]
        public string PartnerNumber { get; set; }

        
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Croatian PIN must be 11 digits.")]
        public string CroatianPIN { get; set; }

        
        [Required(ErrorMessage = "Partner type is required. Possible values are 1 (Personal) or 2 (Legal).")]
        [Range(1, 2, ErrorMessage = "Invalid PartnerTypeId. Possible values are 1 (Personal) or 2 (Legal).")]
        public int PartnerTypeId { get; set; }


        public DateTime CreatedAtUtc { get; set; }

        [Required(ErrorMessage = "Create by user is required.")]
        [StringLength(255, ErrorMessage = "Create by user cannot exceed 255 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string CreateByUser { get; set; }

        
        [Required(ErrorMessage = "Is foreign is required.")]
        public bool IsForeign { get; set; }

        
        [StringLength(20, MinimumLength = 10, ErrorMessage = "External code must be between 10 and 20 characters.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "External code must be alphanumeric.")]
        public string ExternalCode { get; set; }

        
        [Required(ErrorMessage = "Gender is required. Possible values are M, F, or N.")]
        [StringLength(1, ErrorMessage = "Gender must be a single character.")]
        [RegularExpression("^[M|F|N]$", ErrorMessage = "Invalid gender. Possible values are M, F, or N.")]
        public string Gender { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } set { } }
    }
}
