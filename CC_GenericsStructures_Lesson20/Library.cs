using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_GenericsStructures_Lesson20
{
    internal class Library: IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {

        }

        public IEnumerator<Book> GetEnumerator()
        {
            return null;//new BookEnumerator<Book>(books);
        }

        public void RemoveBook(Book book)
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return null;
        //}
    }
}
