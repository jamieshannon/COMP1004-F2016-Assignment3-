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

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //hide the splash form
            this.Hide();

            //create an object for the next form
            SelectionForm selectionForm = new SelectionForm();

            //add property in next form to point to this form

            //point this form to the parent form
            selectionForm.previousForm = this;

            //show the next form
            selectionForm.Show();

            //disable the timer event
            SplashFormTimer.Enabled = false;
        }
    }
}
