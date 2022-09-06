using Kutuphanem.DataAccess.Concretes.EfConcretes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kutuphanem.DataAccess.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AuthorRepository authorRepository = new AuthorRepository();

            //authorRepository.Insert(new Entity.Concrete.Author { BookId = 1, Name = "Ali Kara" });

            //Assert.AreEqual(1, authorRepository.GetAll().Count);

            BookRepository bookRepository = new BookRepository();

            bookRepository.Insert(new Entity.Concrete.Book { AuthorId = 1, PersonelId = 1, CategoryId = 1, UserId = 1, BookName = "Kitap 1", ISBN = "11111" });

            Assert.AreEqual(1, bookRepository.GetAll().Count);
        }
    }
}
