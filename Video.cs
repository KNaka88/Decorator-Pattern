using System;

namespace Decorator
{
    class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;
        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo -----");
            Console.WriteLine($" Director: {_director}");
            Console.WriteLine($" # Copies: {NumCopies}");
            Console.WriteLine($" Playtime: {_playTime}");
        }
    }
}