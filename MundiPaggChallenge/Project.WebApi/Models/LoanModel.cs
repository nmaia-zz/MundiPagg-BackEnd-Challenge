using System;
using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models
{
    public class LoanModelRegister
    {
        public bool Loaned { get; set; }

        [Required(ErrorMessage = "The Person is required.")]
        public Guid PersonId { get; set; }

        [Required(ErrorMessage = "The Item is required.")]
        public Guid ItemId { get; set; }

    }

    public class LoanModelEdition
    {
        [Required(ErrorMessage = "The Loan is required.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Loaned field is required.")]
        public bool Loaned { get; set; }

        [Required(ErrorMessage = "The Person is required.")]
        public Guid PersonId { get; set; }

        [Required(ErrorMessage = "The Item is required.")]
        public Guid ItemId { get; set; }
    }

    public class LoanModelConsultation
    {
        public Guid Id { get; set; }
        public bool Loaned { get; set; }
    }
}