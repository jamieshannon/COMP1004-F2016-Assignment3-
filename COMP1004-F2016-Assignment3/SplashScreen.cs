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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hide the splash screen and display the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //hide the splash form
            this.Hide();

            //create an object for the next form
            SelectionForm selectionForm = new SelectionForm();

            //point this form to the parent form
            selectionForm.previousForm = this;

            //show the next form
            selectionForm.Show();

            //disable the timer event
            SplashFormTimer.Enabled = false;
        }
    }
}
