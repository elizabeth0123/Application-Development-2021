using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace application_development_2021
{
    public partial class Form4 : Form
    {
        const int ListSize = 100;

        public Form4()
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            const string message =
          "Are you sure that you would like to close this window?";
            const string caption = "Closing Application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        Form1 firstForm = new Form1();
        private void bttnHome_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();
        }

        private void bttnFill_Click(object sender, EventArgs e)
        {
            int ix;

            Random rndm = new Random();

            for (ix = 0; ix < ListSize; ix++)
            {
                int RandomNumber = rndm.Next(0, 100);
                lblRandom.Items.Add(RandomNumber);
            }
            txtNumber.Focus();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            bool numberFound;
            int index;
            int Search;
          

            index = 0;
            numberFound = false;

            string setSearch = Convert.ToString(txtNumber.Text);
            Search = Convert.ToInt32(setSearch);
            index = Search;

            do
            {
                if (lblRandom.Items.Contains(index))
                {
                    numberFound = true;
                }
                else
                {
                    index = index + 1;
                }
            } while ((numberFound == false) && (index <= ListSize));

            if (numberFound == true)
            {
                string cSearch = Convert.ToString(Search);
                txtFoundorNot.Text = cSearch + " Found";
            }
            else
            {
                string iSearch = Convert.ToString(Search);
                txtFoundorNot.Text = iSearch + " Not Found";
            }

        }
        Form3 thirdForm = new Form3();
        private void bttnanimation_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
            this.Hide();
        }
    }
}
