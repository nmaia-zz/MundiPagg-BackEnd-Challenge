using Project.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models
{
    public class MediaModelRegister
    {
        [MaxLength(100, ErrorMessage = "The Title field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "The Title field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Register Date is required.")]
        public DateTime RegisterDate { get; set; }

        [Required(ErrorMessage = "The Release Date is required.")]
        public DateTime ReleaseDate { get; set; }

        //[Required(ErrorMessage = "The Item Type is required.")]
        //public string ItemType { get; set; }

        [Required(ErrorMessage = "The Media Type is required.")]
        public string MediaType { get; set; }

        [Required(ErrorMessage = "The Genre is required.")]
        public string Genre { get; set; }
    }

    public class MediaModelEdition
    {
        [Required(ErrorMessage = "The Book Id is required.")]
        public Guid Id { get; set; }

        [MaxLength(100, ErrorMessage = "This field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Register Date is required.")]
        public DateTime RegisterDate { get; set; }

        [Required(ErrorMessage = "The Release Date is required.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The Item Type is required.")]
        public string ItemType { get; set; }

        [Required(ErrorMessage = "The Media Type is required.")]
        public string MediaType { get; set; }

        [Required(ErrorMessage = "The Genre is required.")]
        public string Genre { get; set; }
    }

    public class MediaModelConsultation
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ItemType { get; set; }
        public string MediaType { get; set; }
        public string Genre { get; set; }
        public Guid LoanId { get; set; }
        public bool Loaned { get; set; }
        public string FirstName { get; set; }
        public string Cellphone { get; set; }
    }
}