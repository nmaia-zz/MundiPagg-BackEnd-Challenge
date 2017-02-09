using Project.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.WebApi.Models
{
    public class BookModelRegister
    {
        [MaxLength(100, ErrorMessage = "The Title field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "The Title field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Register Date is required.")]
        public DateTime RegisterDate { get; set; }

        [Required(ErrorMessage = "The Release Date is required.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The Item Type is required.")]
        public string ItemType { get; set; }

        [MaxLength(100, ErrorMessage = "The Author field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "The Author field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Author is required.")]
        public string Author { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Please, insert only numbers.")]
        [Required(ErrorMessage = "The Number of Pages is required.")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "The Publishing Company is required.")]
        public string PublishingCompany { get; set; }

        [Required(ErrorMessage = "The Genre is required.")]
        public string Genre { get; set; }
    }

    public class BookModelEdition
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

        [MaxLength(100, ErrorMessage = "This field has {1} as the maximum number of characters.")]
        [MinLength(6, ErrorMessage = "This field has {1} as the minimum number of characters.")]
        [Required(ErrorMessage = "The Author is required.")]
        public string Author { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Please, insert only numbers.")]
        [Required(ErrorMessage = "The Number of Pages is required.")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "The Publishing Company is required.")]
        public string PublishingCompany { get; set; }

        [Required(ErrorMessage = "The Genre is required.")]
        public string Genre { get; set; }
    }

    public class BookModelConsultation
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ItemType { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string PublishingCompany { get; set; }
        public string Genre { get; set; }
        public Guid LoanId { get; set; }
        public bool Loaned { get; set; }
    }
}