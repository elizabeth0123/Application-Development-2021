using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Testing_microsoft_example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //GENERATING RANDOM ARRAY
            Random rndm = new Random();
            for (int ix = 0; ix < numbers.Length; ix++)
            {
                numbers[ix] = rndm.Next(1, 1000);
            }

            string strRnd = "Random Array: ";
            for (int ix = 0; ix < (numbers.Length - 1); ix++)
            {
                strRnd += numbers[ix].ToString() + ",";
            }
            strRnd += numbers[numbers.Length - 1].ToString();
            //lblRandom.Text = strRnd;
            MessageBox.Show(Text);

            {
                bttnsortingalgo.Visible = false;
                bttnsearchingalgo.Visible = false;
                bttnBinarysearch.Visible = false;
                bttnBubblesort.Visible = false;
                bttnLinearsearch.Visible = false;
                bttnSelectionsort.Visible = false;
                bttnstart.Visible = true;
                bttnclear.Visible = true;
            }


            //getting results to be displayed
            string strArraySorted = "Sorted Array; ";
            for (int ix = 0; ix < (numbers.Length - 1); ix++)
            {
                strArraySorted += numbers[ix].ToString() + ",";
            }
            strArraySorted += numbers[numbers.Length - 1].ToString();
            lblSorted.Text = strArraySorted;
        }


        //declaring Swap
        private static bool swap(ref int top, ref int bottom)
        {
            int temp;
            if (top <= bottom)
                return false;
            temp = top;
            top = bottom;
            bottom = temp;
            return true;
            { // swap()
            }


            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Hide();


            { //should give error box on close with box selections
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
