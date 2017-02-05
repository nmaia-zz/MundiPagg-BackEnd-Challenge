using System;
using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models
{
    public class LoanModelRegister
    {
        [Required(ErrorMessage = "The Loaned field is required.")]
        public bool Loaned { get; set; }
    }

    public class LoanModelEdition
    {
        [Required(ErrorMessage = "The Loan Id is required.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Loaned field is required.")]
        public bool Loaned { get; set; }
    }

    public class LoanModelConsultation
    {
        public Guid Id { get; set; }
        public bool Loaned { get; set; }
    }
}