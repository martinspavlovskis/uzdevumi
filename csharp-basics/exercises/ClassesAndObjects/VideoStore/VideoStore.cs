using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videoSelection = new List<Video>();
        public VideoStore()
        {
            
        }

        public void AddVideo(string title)
        {
            this._videoSelection.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach(var movie in _videoSelection.Where(m => m.title == title))
            {
                movie.BeingCheckedOut();
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var movie in _videoSelection.Where(m => m.title == title))

            {
                movie.BeingReturned();
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var movie in _videoSelection)
            {
                if (movie.title == title) movie.ReceivingRating(rating);
            }
        }

        public void ListInventory()
        {
            Console.WriteLine(string.Join(", ", _videoSelection));
        }
    }
}
