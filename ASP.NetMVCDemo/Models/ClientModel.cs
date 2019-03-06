using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NetMVCDemo.Models
{
    public class ClientModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "We need their first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "We need their last name.")]
        public string LastName { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "We need their company name.")]
        public string CompanyName { get; set; }

        [Display(Name = "Company Address")]
        [Required(ErrorMessage = "We need their company address.")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Company PostCode")]
        [Required(ErrorMessage = "We need their company postcode.")]
        [DataType(DataType.PostalCode)]
        public string CompanyPostCode { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "We need their email address.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "The email and confirm email must match!")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "We need their contact number.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Confirm Phone Number")]
        [Compare("PhoneNumber", ErrorMessage = "The phone number and confirm phone number must match!")]
        [DataType(DataType.PhoneNumber)]
        public string ConfirmPhoneNumber { get; set; }
    }
}