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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    static class Program
    {
        public static Movie movie = new Movie();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
