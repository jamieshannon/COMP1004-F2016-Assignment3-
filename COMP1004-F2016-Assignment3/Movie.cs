/*
 * App Name: Movie Bonanza
 * Name: Jamie Shannon
 * StudentID: 200328763
 * Date: Nov. 11/16
 * Description: Multi-form application that allows the user to select a movie from a list.
 * Calculates the cost of the movie and notifies that user when the movie is going to stream.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_F2016_Assignment3
{
    class Movie
    {
        public String Title
        {
            get; set;
        }

        public String Category
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public double GrandTotal
        {
            get; set;
        }
    }
}
