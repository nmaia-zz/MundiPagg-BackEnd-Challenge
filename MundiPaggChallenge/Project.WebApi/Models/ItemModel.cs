using Project.Domain.Entities;
using System;

namespace Project.WebApi.Models
{
    public class ItemModelConsultation
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ItemType { get; set; }
        public string Genre { get; set; }
        public Guid LoanId { get; set; }
        public bool Loaned { get; set; }
    }
}