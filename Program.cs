using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("JK Rowling", "Harry Potter", 10);
            book.Display();

            var video = new Video("George Lucas", "Star Wars", 30, 120);
            video.Display();

            Console.WriteLine("\nMaking video borrowable:");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.ReadKey();
        }
    }
}
