﻿namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator() => books.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        #region IEnumerator implementation section

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(this.books);
        //}

        //IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        //private class LibraryIterator : IEnumerator<Book>
        //{
        //    private readonly List<Book> books;
        //    private int currentIndex;

        //    public LibraryIterator(IEnumerable<Book> books)
        //    {
        //        this.Reset();
        //        this.books = new List<Book>(books);
        //    }

        //    public bool MoveNext() => ++this.currentIndex < this.books.Count;

        //    public void Reset() => this.currentIndex = -1;

        //    public Book Current => this.books[this.currentIndex];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {

        //    }
        //}

        #endregion
    }
}
