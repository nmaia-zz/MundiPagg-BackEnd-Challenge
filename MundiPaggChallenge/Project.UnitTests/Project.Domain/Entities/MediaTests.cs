using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Domain.Entities;
using Project.Domain.Entities.Types;

namespace Project.UnitTests.Project.Domain.Entities
{
    [TestClass]
    public class MediaTests
    {
        [TestMethod]
        public void TestIncludOfMedia_Success()
        {
            var model = new Media();
            model.Genre = Genre.Fiction;

            model.Id = Guid.NewGuid();
            model.Title = "Title";
            model.RegisterDate = DateTime.Today;
            model.ReleaseDate = DateTime.Today;
            model.ItemType = ItemType.Media;

            var modelLoan = new Loan();

            model.Loan = model.Loan;
            model.LoanId = modelLoan.Id;

            Assert.AreNotEqual(model.Id, Guid.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIncludOfMedia_Error()
        {
            var model = new Media();
            model.Genre = Genre.Movie;

            model.Id = Guid.NewGuid();
            model.Title = "Title";
            model.RegisterDate = DateTime.Today;
            model.ReleaseDate = DateTime.Today;
            model.ItemType = ItemType.Media;

            var modelLoan = new Loan();
            modelLoan.Id = Guid.Empty;

            model.SetLoan(modelLoan);
        }
    }
}
