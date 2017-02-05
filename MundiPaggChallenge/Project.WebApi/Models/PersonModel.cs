using System;
using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models
{
    public class PersonModelRegister
    {
        [MaxLength(100, ErrorMessage = "This field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The First Name is required.")]
        public string FirstName { get; set; }

        [MaxLength(100, ErrorMessage = "This field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Birth Date is required.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "The Gender is required.")]
        public string Gender { get; set; }
    }

    public class PersonModelEdition
    {
        [Required(ErrorMessage = "The Person Id is required.")]
        public Guid Id { get; set; }

        [MaxLength(100, ErrorMessage = "This field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The First Name is required.")]
        public string FirstName { get; set; }

        [MaxLength(100, ErrorMessage = "This field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Birth Date is required.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "The Gender is required.")]
        public string Gender { get; set; }
    }

    public class PersonModelConsultation
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}