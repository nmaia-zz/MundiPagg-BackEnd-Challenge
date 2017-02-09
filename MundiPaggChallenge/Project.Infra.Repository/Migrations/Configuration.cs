namespace Project.Infra.Repository.Migrations
{
    using Domain.Entities;
    using Domain.Entities.Types;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Project.Infra.Repository.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project.Infra.Repository.Context.DataContext context)
        {
            #region ' --- Persons --- '

            var person_1 = context.Persons.Add(new Person { Id = Guid.Parse("594449c4-ba67-4f59-96ca-797aec2f8f51"), FirstName = "Raissa", LastName = "Melo", Gender = Gender.F, BirthDate = Convert.ToDateTime("1997-12-27"), Cellphone = "021999911517", Email = "mozoculero@apkmd.com" });
            var person_2 = context.Persons.Add(new Person { Id = Guid.Parse("60ea65e5-d29e-46dc-801a-dad35d39df9e"), FirstName = "Júlia", LastName = "Castro", Gender = Gender.F, BirthDate = Convert.ToDateTime("1985-04-01"), Cellphone = "021999910224", Email = "zacis@vps.com" });
            var person_3 = context.Persons.Add(new Person { Id = Guid.Parse("5f397ccd-c2aa-4a5a-91f5-d486bfae678b"), FirstName = "Marisa", LastName = "Ferreira", Gender = Gender.F, BirthDate = Convert.ToDateTime("1983-08-01"), Cellphone = "021999781517", Email = "lixuti@nutpa.com" });
            var person_4 = context.Persons.Add(new Person { Id = Guid.Parse("16a2e806-7d15-43b1-8b7d-8134a92f4faf"), FirstName = "Bruna", LastName = "Sousa", Gender = Gender.F, BirthDate = Convert.ToDateTime("1982-07-27"), Cellphone = "021999367474", Email = "neriyab@nutpa.com" });
            var person_5 = context.Persons.Add(new Person { Id = Guid.Parse("90a3bf00-d693-41f1-8269-5208394a9b9d"), FirstName = "Alice", LastName = "Dias", Gender = Gender.F, BirthDate = Convert.ToDateTime("1988-07-23"), Cellphone = "021999982190", Email = "cetemal@loang.com" });
            var person_6 = context.Persons.Add(new Person { Id = Guid.Parse("c61e1f8f-89a0-41c2-ad40-d90e39413b1f"), FirstName = "Tomás", LastName = "Araujo", Gender = Gender.M, BirthDate = Convert.ToDateTime("1992-03-19"), Cellphone = "021999987372", Email = "codazax@vps.com" });
            var person_7 = context.Persons.Add(new Person { Id = Guid.Parse("72781650-eb64-46ea-a92d-6432b1ca48b9"), FirstName = "Kauan", LastName = "Pereira", Gender = Gender.M, BirthDate = Convert.ToDateTime("1983-04-26"), Cellphone = "021999366838", Email = "sojicur@car.com" });

            #endregion

            #region ' --- Loans --- '

            var loan_1 = context.Loans.Add(new Loan { Id = Guid.Parse("b9d35b0a-cddb-475b-8b2d-31060123adba"), Loaned = false });
            var loan_2 = context.Loans.Add(new Loan { Id = Guid.Parse("18c2c023-a569-465f-b323-34617a409125"), Loaned = false });
            var loan_3 = context.Loans.Add(new Loan { Id = Guid.Parse("bdfab6e4-5ff2-47a9-a0ce-3ba3cbb1c598"), Loaned = false });
            var loan_4 = context.Loans.Add(new Loan { Id = Guid.Parse("ddeb0a35-c5cc-4cb6-905f-6b1c05b2c469"), Loaned = true, Person = person_4, PersonId = person_4.Id });
            var loan_5 = context.Loans.Add(new Loan { Id = Guid.Parse("285f6598-c42e-4caf-a6aa-a5c592c8e6b4"), Loaned = true, Person = person_5, PersonId = person_5.Id });
            var loan_6 = context.Loans.Add(new Loan { Id = Guid.Parse("e2b7c0a1-8e61-45b2-8257-b237bed78f23"), Loaned = true, Person = person_6, PersonId = person_6.Id });
            var loan_7 = context.Loans.Add(new Loan { Id = Guid.Parse("098b30db-50d0-4cf7-bf26-f2f08f03c968"), Loaned = true, Person = person_7, PersonId = person_7.Id });
            var loan_8 = context.Loans.Add(new Loan { Id = Guid.Parse("639fc00e-190b-43f6-9928-fbae7e6f1d10"), Loaned = false });
            var loan_9 = context.Loans.Add(new Loan { Id = Guid.Parse("af555c04-b0ee-4f42-a041-b6c0747b0d20"), Loaned = false });
            var loan_10 = context.Loans.Add(new Loan { Id = Guid.Parse("e3eb3ca8-fba8-4dd0-8420-0a050196c1d9"), Loaned = false });

            #endregion

            #region ' --- Items --- '

            #region ' Books '

            context.Books.Add(new Book { Id = Guid.Parse("a7202a94-452e-49d1-b4e7-9f6926e1af35"), Title = "The Lord of The Rings - The Return of the King", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("1955-10-20"), Author = "J.R.R. Tolkien", Pages = 490, PublishingCompany = "Martins Fontes", Genre = Genre.Other, ItemType = ItemType.Book, Loan = loan_1, LoanId = loan_1.Id });
            context.Books.Add(new Book { Id = Guid.Parse("760bb05b-786d-4515-baea-443da49e63a5"), Title = "The Lord of The Rings - The Two Towers", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("1954-11-11"), Author = "J.R.R. Tolkien", Pages = 352, PublishingCompany = "Martins Fontes", Genre = Genre.Other, ItemType = ItemType.Book, Loan = loan_2, LoanId = loan_2.Id });
            context.Books.Add(new Book { Id = Guid.Parse("59c5e07e-8c91-4681-bc33-ba0631790e1c"), Title = "American Sniper", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("2012-01-02"), Author = "Chris Kyle", Pages = 324, PublishingCompany = "Intrinseca", Genre = Genre.Other, ItemType = ItemType.Book, Loan = loan_3, LoanId = loan_3.Id });
            context.Books.Add(new Book { Id = Guid.Parse("377c3cbb-5b5a-41b1-8dc9-b2ec0ccd0fa0"), Title = "No Easy Day", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("2012-09-04"), Author = "Mark Owen", Pages = 324, PublishingCompany = "Paralela", Genre = Genre.Other, ItemType = ItemType.Book, Loan = loan_4, LoanId = loan_4.Id });
            context.Books.Add(new Book { Id = Guid.Parse("817d515b-4478-48ce-94f2-e6f97d054edf"), Title = "Steve Jobs", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("2011-10-24"), Author = "Walter Isaacson", Pages = 324, PublishingCompany = "Companhia das Letras", Genre = Genre.Other, ItemType = ItemType.Book, Loan = loan_5, LoanId = loan_5.Id });

            #endregion

            #region ' Medias '

            context.Medias.Add(new Media { Id = Guid.Parse("475c11e0-5c05-4278-91a9-36788c1626f1"), Title = "Hardwired... to Self-Destruct", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("2016-11-18"), ItemType = ItemType.Media, MediaType = MediaType.CD, Genre = Genre.Music, Loan = loan_6, LoanId = loan_6.Id });
            context.Medias.Add(new Media { Id = Guid.Parse("7165e6fe-2361-42b7-a142-384c79146cfc"), Title = "The song remains the same", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("1976-10-22"), ItemType = ItemType.Media, MediaType = MediaType.CD, Genre = Genre.Music, Loan = loan_7, LoanId = loan_7.Id });
            context.Medias.Add(new Media { Id = Guid.Parse("1253a608-dafe-4260-bba7-a956d9d5858f"), Title = "Lord of the Rings: The Two Towers", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("2003-08-26"), ItemType = ItemType.Media, MediaType = MediaType.DVD, Genre = Genre.Movie, Loan = loan_8, LoanId = loan_8.Id });
            context.Medias.Add(new Media { Id = Guid.Parse("7780db8a-a6b1-4afa-bc7a-729a67c99a8a"), Title = "Star Wars: The Force Awakens", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("2016-04-05"), ItemType = ItemType.Media, MediaType = MediaType.DVD, Genre = Genre.Movie, Loan = loan_9, LoanId = loan_9.Id });
            context.Medias.Add(new Media { Id = Guid.Parse("18b0cc34-be79-4034-b661-f862b46f239f"), Title = "The Matrix", RegisterDate = DateTime.Now, ReleaseDate = Convert.ToDateTime("1999-09-21"), ItemType = ItemType.Media, MediaType = MediaType.DVD, Genre = Genre.Movie, Loan = loan_10, LoanId = loan_10.Id });

            #endregion

            #endregion
        }
    }
}