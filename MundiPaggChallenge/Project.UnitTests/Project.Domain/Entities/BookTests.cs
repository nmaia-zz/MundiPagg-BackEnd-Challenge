using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Domain.Entities;
using Project.Domain.Entities.Types;

namespace Project.UnitTests.Project.Domain.Entities
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestIncludOfBook_Success()
        {
            var model = new Book();
            model.Author = "Author";
            model.Genre = Genre.Fiction;
            model.Pages = 500;
            model.PublishingCompany = "PublishingCompany";

            model.Id = Guid.Parse("F75E8477-BEC0-431F-A164-BA038A49FC0B");
            model.Title = "Title";
            model.RegisterDate = DateTime.Today;
            model.ReleaseDate = DateTime.Today;
            model.ItemType = ItemType.Book;

            var modelLoan = new Loan();
            modelLoan.Id = Guid.Parse("8EEBDF0D-95F0-4C30-BAFB-37A3D97EEA9B");

            model.Loan = model.Loan;
            model.LoanId = modelLoan.Id;

            Assert.AreNotEqual(model.Id, Guid.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIncludOfBook_Error()
        {
            var model = new Book();
            model.Author = "Author";
            model.Genre = Genre.Fiction;
            model.Pages = 500;
            model.PublishingCompany = "PublishingCompany";

            model.Id = Guid.NewGuid();
            model.Title = "Title";
            model.RegisterDate = DateTime.Today;
            model.ReleaseDate = DateTime.Today;
            model.ItemType = ItemType.Book;

            var modelLoan = new Loan();
            modelLoan.Id = Guid.Empty;

            model.SetLoan(modelLoan);
        }
    }
}
