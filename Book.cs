using System;

namespace Decorator
{
    // The ConcreteComponent class
    class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ----- ");
            Console.WriteLine($" Author: {_author}");
            Console.WriteLine($" Title: {_title}");
            Console.WriteLine($" # Copies: {NumCopies}");
        }
    }
}
