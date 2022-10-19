using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingHandson;

namespace LibraryTest
{
    [TestFixture]
    public class TestingHandle
    {

        [Test]
        [SetUp]

        public void GetBookName()
        {

            LibraryDBoperations opr = new LibraryDBoperations();

            string bname =opr.GetBookName();

            Assert.AreEqual("Attitude is everything", bname, "Book not found....");

        }

        [Test]

        public void GetBookAuthor()
        {

            LibraryDBoperations opr = new LibraryDBoperations();

            string Aname = opr.GetBookAuthor();

            Assert.AreEqual("jeff keller                   ", Aname, "Author not found....");

        }
    }
}
