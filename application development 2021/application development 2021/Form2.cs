using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace application_development_2021
{
    public partial class Form2 : Form
    {
        int[] numbers = new int[10];
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
            lblRandom.Text = strRnd;
           // MessageBox.Show(Text);

            //BUBBLE SORT
            bool order1 = false;
            while(!order1)
            {
                order1 = true;
                for (int ix = 0; ix < (numbers.Length -1); ix++)
                {
                    if (swap(ref numbers[ix], ref numbers[ix+1]))
                        order1 = false;
                }
            }
            //getting results to be displayed
            string strArraySorted = "Sorted Array; ";
            for (int ix =0; ix < (numbers.Length - 1); ix++)
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
        } // swap()
        

        Form3 thirdForm = new Form3();
        private void bttnanimation2_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
            this.Hide();
        }

        Form1 firstForm = new Form1();
        private void bbtnHomepage_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();

        }

        private void bttnExit2_Click(object sender, EventArgs e)
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
    }
}

