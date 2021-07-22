using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        public string title;
        private bool _isCheckedOut = false;       
        private int _ratingCount;
        private double _moviesTotalRatingPoints;
        public Video(string title)
        {
            this.title = title;
        }

        public void BeingCheckedOut()
        {
            this._isCheckedOut = true;
        }

        public void BeingReturned()
        {
            this._isCheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            this._moviesTotalRatingPoints += rating;
            this._ratingCount++;
        }

        public double AverageRating()
        {
            if(this._ratingCount > 0)
            {
                return this._moviesTotalRatingPoints / this._ratingCount;
            } else
            {
                return 0.00;
            }
        }

        public bool Available()
        {
            if(this._isCheckedOut)
            {
                return false;
            } else
            {
                return true;
            }
        }       

        public override string ToString()
        {
            return $"{title}, {AverageRating()}, {Available()}";
        }
    }
}
