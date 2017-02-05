using System;
using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models
{
    public class ContactModelRegister
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please, insert only numbers.")]
        [MaxLength(14, ErrorMessage = "This field has {1} as the limit number of characters.")]
        [MinLength(9, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Cellphone is required.")]
        public string Cellphone { get; set; }

        [EmailAddress(ErrorMessage = "Please, insert the email in the correct format.")]
        [Required(ErrorMessage = "The e-mail is required.")]
        public string Email { get; set; }
    }

    public class ContactModelEdition
    {
        [Required(ErrorMessage = "The Contact Id is required.")]
        public Guid Id { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Please, insert only numbers.")]
        [MaxLength(14, ErrorMessage = "This field has {1} as the limit number of characters.")]
        [MinLength(9, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Cellphone is required.")]
        public string Cellphone { get; set; }

        [EmailAddress(ErrorMessage = "Please, insert the email in the correct format.")]
        [Required(ErrorMessage = "The e-mail is required.")]
        public string Email { get; set; }
    }

    public class ContactModelConsultation
    {
        public Guid Id { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
    }
}