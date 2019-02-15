using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace Gaffgc_App.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        // Note Validation will only trigger server side on user event in input field. Override the event handler function is recommended
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string UserNameOption { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]        
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        // Location API required for this to fully work

        [Display(Name = "No.")]
        public string AdressNumber { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }
        [Display(Name = "Adress Line 2")]
        public string AdressLine2 { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }

        [Display(Name = "Postcode")]
        [DataType(DataType.PostalCode)]
        public int Postcode { get; set; }

        // Education
        [Display(Name = "Subject")]
        public string subject { get; set; }

        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public string SchoolEndDate { get; set; }

        [Display(Name = "Other Qualifications")]
        public string Qualifications { get; set; }

        // Skills and Trades
        [Display(Name = "Company Name")]
        public string company { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public string JobEndDate { get; set; }

        // Previous
        [Display(Name = "Company Name")]
        public string company2 { get; set; }

        [Display(Name = "Position")]
        public string Position2 { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public string JobEndDate2 { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Profession")]
        public string Profession { get; set; }

        [Required]
        [Display(Name = "Language")]
        public string Language { get; set; }

        [Display(Name = "Religion")]
        public string Religion { get; set; }

        [Required]
        [Display(Name = "Lineage")]
        public string Lineage { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MustBeChecked(ErrorMessage = "By registering I accept terms and conditions.")]
        public bool AcceptedUA { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class MustBeChecked : ValidationAttribute, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            return (!(value is bool) || (bool)value);
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
            rule.ValidationType = "mandatory";
            yield return rule;
        }
    }

}
