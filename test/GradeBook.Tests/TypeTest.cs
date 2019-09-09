using System;
using Xunit;

namespace GradeBook.Tests
{    
    public class TypeTest
    {
        [Fact]
        public void CsharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetbookSetName(book1,"new name");

            Assert.Equal("new name",book1.Name);
        }

        private void GetbookSetName(Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CanSendNameFormReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1,"new name");

            Assert.Equal("new name",book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);
            Assert.NotEqual(book1,book2);
        }

        public void TwoVarsCanReferenceSameObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1,book2);
            Assert.True(object.ReferenceEquals(book1,book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
