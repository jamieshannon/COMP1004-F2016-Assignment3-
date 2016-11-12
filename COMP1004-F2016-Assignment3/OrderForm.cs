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
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;

        Movie movie = Program.movie;
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Oopens the next form, while hiding the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            //Instantiate a new StreamForm object 
            StreamForm streamForm = new StreamForm();
            //hide this form
            this.Hide();
            //show next form
            streamForm.Show();
        }


        /// <summary>
        /// Shows a print dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
        }

        /// <summary>
        /// Shows the about menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        /// <summary>
        /// Calculates totals based on the movie selected on the previous form.
        /// Shows an image of the movie selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {

            // Set the text box text values to the appopriate text
            TitleTextBox.Text = movie.Title;
            CategoryTextBox.Text = movie.Category;
            CostTextBox.Text = movie.Price.ToString("C2");
            SubTotalTextBox.Text = movie.Price.ToString("C2");
            CalculateDefaultCosts();


            // determine which movie was selected and display an image for it
            if (TitleTextBox.Text == "Season of the Witch" || TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.Season_of_the_Witch;
            }
            else if (TitleTextBox.Text == "I am Number Four")
            {
                MoviePictureBox.Image = Properties.Resources.I_Am_Number_Four;
            }
            else if (TitleTextBox.Text == "The Green Hornet")
            {
                MoviePictureBox.Image = Properties.Resources.the_green_hornet;
            }
            else if (TitleTextBox.Text == "Death Race 2")
            {
                MoviePictureBox.Image = Properties.Resources.death_race_2;
            }
            else if (TitleTextBox.Text == "The Mechanic")
            {
                MoviePictureBox.Image = Properties.Resources.the_mechanic;
            }
            else if (TitleTextBox.Text == "Sanctum")
            {
                MoviePictureBox.Image = Properties.Resources.Sanctum;
            }
            else if (TitleTextBox.Text == "The Other Woman")
            {
                MoviePictureBox.Image = Properties.Resources.The_Other_Woman;
            }
            else if (TitleTextBox.Text == "The Eagle")
            {
                MoviePictureBox.Image = Properties.Resources.The_Eagle;
            }
            else if (TitleTextBox.Text == "The Dilema")
            {
                MoviePictureBox.Image = Properties.Resources.The_Dilemma;
            }
            else if (TitleTextBox.Text == "No Strings Attached")
            {
                MoviePictureBox.Image = Properties.Resources.no_strings_attached;
            }
            else if (TitleTextBox.Text == "Cedar Rapids")
            {
                MoviePictureBox.Image = Properties.Resources.cedar_rapids;
            }
            else if (TitleTextBox.Text == "Just Go With It")
            {
                MoviePictureBox.Image = Properties.Resources.Just_Go_with_It;
            }
            else if (TitleTextBox.Text == "Company Men")
            {
                MoviePictureBox.Image = Properties.Resources.company_men;
            }
            else if (TitleTextBox.Text == "The Way Back")
            {
                MoviePictureBox.Image = Properties.Resources.The_Way_Back;
            }
            else if (TitleTextBox.Text == "Waiting for Forever")
            {
                MoviePictureBox.Image = Properties.Resources.Waiting_for_Forever;
            }

            else if (TitleTextBox.Text == "The Rite")
            {
                MoviePictureBox.Image = Properties.Resources.the_rite;
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                MoviePictureBox.Image = Properties.Resources.the_roommate;
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                MoviePictureBox.Image = Properties.Resources.gnomeo_and_juliet;
            }
            else if (TitleTextBox.Text == "Real Steel")
            {
                MoviePictureBox.Image = Properties.Resources.Real_Steel;
            }
            else if (TitleTextBox.Text == "Footloose")
            {
                MoviePictureBox.Image = Properties.Resources.footloose;
            }
        }

        /// <summary>
        /// Calculates and displays the default costs of the movie if not purchasing
        /// </summary>
        private void CalculateDefaultCosts()
        {
            // calculate the sales tax, and grandtotal
            double SalesTax = movie.Price * .13;
            SalesTaxTextBox.Text = SalesTax.ToString("C2");

            double GrandTotal = movie.Price + SalesTax;
            GrandTotalTextBox.Text = GrandTotal.ToString("C2");

            movie.GrandTotal = GrandTotal;
        }

        /// <summary>
        /// Makes the hidden fields visible if the user wants to purchase the movie.
        /// Updates the calculated totals based on the new purchase cost.
        /// Reverses these changes when the check box is unchecked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PurchaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PurchaseCheckBox.Checked)
            {
                // Make the purchaselabel and textbox visible
                PurchaseLabel.Visible = true;
                PurchaseTextBox.Visible = true;

                // display the purchase cost
                PurchaseTextBox.Text = 10.00.ToString("C2");

                // calculate the new costs and display them
                double SubTotal = movie.Price + 10;
                SubTotalTextBox.Text = SubTotal.ToString("C2");

                double SalesTax = SubTotal * .13;
                SalesTaxTextBox.Text = SalesTax.ToString("C2");

                double GrandTotal = SubTotal + SalesTax;
                GrandTotalTextBox.Text = GrandTotal.ToString("C2");

                movie.GrandTotal = GrandTotal;
            }
            else
            {
                PurchaseLabel.Visible = false;
                PurchaseTextBox.Visible = false;

                CalculateDefaultCosts();
            }
        }


        /// <summary>
        /// show the previous form and hide this form when the back button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
