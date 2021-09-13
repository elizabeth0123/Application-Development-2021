using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_development_2021
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, System.EventArgs e)
        {
            bttnsortingalgo.Visible = true;
            bttnsearchingalgo.Visible = true;
            bttnBinarysearch.Visible = false;
            bttnBubblesort.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnstart.Visible = false;
            bttnclear.Visible = false;
        }
        private void bttnsortingalgo_click(object sender, System.EventArgs e)
        {
            bttnsortingalgo.Visible = false;
            bttnsearchingalgo.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnBubblesort.Visible = true;
            bttnLinearsearch.Visible = false;
            bttnSelectionsort.Visible = true;
            bttnstart.Visible = false;
            bttnclear.Visible = false;
        }
        private void bttnsearchingalgo_click( object sender, System.EventArgs e)
        {
            bttnsortingalgo.Visible = false;
            bttnsearchingalgo.Visible = false;
            bttnBinarysearch.Visible = true;
            bttnBubblesort.Visible = false;
            bttnLinearsearch.Visible = true;
            bttnSelectionsort.Visible = false;
            bttnstart.Visible = false;
            bttnclear.Visible = false;
        }

        private void bttnBinarysearch_click(object sender, System.EventArgs e)
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

        private void bttnLinearsearch_Click(object sender, System.EventArgs e)
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
        
        private void bttnSelectionsort_Click(object sender, System.EventArgs e)
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

        private void bttnBubblesort_Click(object sender, System.EventArgs e)
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

        private void bttnstart_Click(object sender, System.EventArgs e)
        {
            bttnsortingalgo.Visible = false;
            bttnsearchingalgo.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnBubblesort.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnstart.Visible = false;
            bttnclear.Visible = true;

            Random rnd = new Random();
            for (int ix = 0; ix < numbers.Length; ix++)
            {
                numbers[ix] = rnd.Next(1, 1000);
            }

            string strRnd = "Random Array: ";
            for (int ix = 0; ix < (numbers.Length - 1); ix++)
            {
                strRnd += numbers[ix].ToString() + ",";
            }
            strRnd += numbers[numbers.Length - 1].ToString();
            lblRandom.Text = strRnd;
            //MessageBox.Show (strRnd);
        }

        private void bttnclear_Click(object sender, System.EventArgs e)
        {
            // should clear options and present sorting algorithm or searching algorithm 
            bttnsortingalgo.Visible = true;
            bttnsearchingalgo.Visible = true;
            bttnBinarysearch.Visible = false;
            bttnBubblesort.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnstart.Visible = false;
            bttnclear.Visible = false;
        }
          Form2 secondForm = new Form2();  
        private void bttnanimation_Click(object sender, System.EventArgs e)
        {
            // should open either another tab or another form
            {
                secondForm.Show();
            }
        }

       
    }   

    
}

       