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
    public partial class SelectionForm : Form
    {
        public SplashScreen previousForm;

        public SelectionForm()
        {
            InitializeComponent();
        }

        Movie movie = Program.movie;


        /// <summary>
        /// Display the movie information and image when the selection is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();

            // determine which movie is selected to display the appropriate information and image
            if (TitleTextBox.Text == "Season of the Witch" || TitleTextBox.Text == "I am Number Four")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.Season_of_the_Witch;
            }
            else if (TitleTextBox.Text == "I am Number Four")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.I_Am_Number_Four;
            }
            else if (TitleTextBox.Text == "The Green Hornet")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.the_green_hornet;
            }
            else if (TitleTextBox.Text == "Death Race 2")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.death_race_2;
            }
            else if (TitleTextBox.Text == "The Mechanic")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.the_mechanic;
            }
            else if (TitleTextBox.Text == "Sanctum")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.Sanctum;
            }
            else if (TitleTextBox.Text == "The Other Woman")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.The_Other_Woman;
            }
            else if (TitleTextBox.Text == "The Eagle")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.The_Eagle;
            }
            else if (TitleTextBox.Text == "The Dilema")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.The_Dilemma;
            }
            else if (TitleTextBox.Text == "No Strings Attached")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.no_strings_attached;
            }
            else if (TitleTextBox.Text == "Cedar Rapids")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.cedar_rapids;
            }
            else if (TitleTextBox.Text == "Just Go With It")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.Just_Go_with_It;
            }
            else if (TitleTextBox.Text == "Company Men")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.company_men;
            }
            else if (TitleTextBox.Text == "The Way Back")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.The_Way_Back;
            }
            else if (TitleTextBox.Text == "Waiting for Forever")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.Waiting_for_Forever;
            }

            else if (TitleTextBox.Text == "The Rite")
            {
                CategoryTextBox.Text = "Horror";
                CostTextBox.Text = 2.99.ToString("C2");
                movie.Price = 2.99;
                MoviePictureBox.Image = Properties.Resources.the_rite;
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                CategoryTextBox.Text = "Thriller";
                CostTextBox.Text = 1.99.ToString("C2");
                movie.Price = 1.99;
                MoviePictureBox.Image = Properties.Resources.the_roommate;
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                CategoryTextBox.Text = "Family";
                CostTextBox.Text = 0.99.ToString("C2");
                movie.Price = 0.99;
                MoviePictureBox.Image = Properties.Resources.gnomeo_and_juliet;
            }
            else if (TitleTextBox.Text == "Real Steel")
            {
                CategoryTextBox.Text = "New Release";
                CostTextBox.Text = 4.99.ToString("C2");
                movie.Price = 4.99;
                MoviePictureBox.Image = Properties.Resources.Real_Steel;
            }
            else if (TitleTextBox.Text == "Footloose")
            {
                CategoryTextBox.Text = "New Release";
                CostTextBox.Text = 4.99.ToString("C2");
                movie.Price = 4.99;
                MoviePictureBox.Image = Properties.Resources.footloose;
            }

            String[] UserSelection = { TitleTextBox.Text, CategoryTextBox.Text, CostTextBox.Text };

            // enable next button once a selection has been made
            NextButton.Enabled = true;

            SetMovie();
        }

        /// <summary>
        /// This method sets the movie class values
        /// </summary>
        private void SetMovie()
        {
            movie.Title = TitleTextBox.Text;
            movie.Category = CategoryTextBox.Text;
            
        }

        /// <summary>
        /// Open the next form when the next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //Instantiate a new OrderForm object 
            OrderForm orderForm = new OrderForm();
            //hide this form
            this.Hide();

            orderForm.previousForm = this;
            //show next form
            orderForm.Show();
        }
    }
}
