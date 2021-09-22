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
        int duration = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bttnsearchingalgo.Visible = true;
            bttnsortingalgo.Visible = true;
            bttnLinearsearch.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnBubblesort.Visible = false;
            bttnclear.Visible = false;
        }

        private void bttnsearchingalgo_Click(object sender, EventArgs e)
        {
            bttnsearchingalgo.Visible = false;
            bttnsortingalgo.Visible = false;
            bttnLinearsearch.Visible = true;
            bttnBinarysearch.Visible = true;  
            bttnSelectionsort.Visible = false;
            bttnBubblesort.Visible = false;
            bttnclear.Visible = false;
        }

        private void bttnsortingalgo_Click(object sender, EventArgs e)
        {
            bttnsearchingalgo.Visible = false;
            bttnsortingalgo.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnSelectionsort.Visible = true;
            bttnBubblesort.Visible = true;
            bttnclear.Visible = false;
        }

        private void bttnBinarysearch_Click(object sender, EventArgs e)
        {
            bttnsearchingalgo.Visible = false;
            bttnsortingalgo.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnBubblesort.Visible = false;
            bttnclear.Visible = true;
        }

            //private static int BinarySearch(int[] array, int item)
            //{

            //    var arrayNumbers = new[] { 1, 67, 55, 98, 15, 20, 101, 46, 7 };
            //    Array.Sort(arrayNumbers);

            //    {
            //        int left = 0;
            //        int right = arrayNumbers.Length - 1;

            //        while (left <= right)
            //        {
            //            var middle = (left + right) / 2;

            //            if (arrayNumbers[middle] == item)
            //                return middle;

            //            if (item < arrayNumbers[middle])
            //                right = middle - 1;
            //            else
            //                left = middle + 1;
            //        }
            //        return -1;

            //        var index = (arrayNumbers, 8);
            //        string strindex = "Binary search: ";
            //        strindex = index.ToString();
            //        MessageBox.Show(strindex);
            //    } }
            

        private void bttnLinearsearch_Click(object sender, EventArgs e)
        {
            bttnsearchingalgo.Visible = false;
            bttnsortingalgo.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnBubblesort.Visible = false;
            bttnclear.Visible = true;

            //Random rndm = new Random();
            //for (int ix = 0; ix < numbers.Length; ix++)
            //{
            //    numbers[ix] = rndm.Next(1, 1000);
            //}
            //string strRndm = "Random Array: ";
            //for (int ix = 0; ix < (numbers.Length - 1); ix++)
            //{
            //    strRndm += numbers[ix].ToString() + ",";
            //}
            //strRndm += numbers[numbers.Length - 1].ToString();
            ////lblRandom.Text = strRnd;
            //MessageBox.Show(strRndm);

            Form4 fourthform = new Form4();
            fourthform.Show();
            this.Hide();



        }

        private void bttnSelectionsort_Click(object sender, EventArgs e)
        {
            bttnsearchingalgo.Visible = false;
            bttnsortingalgo.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnBubblesort.Visible = false;
            bttnclear.Visible = true;

            Random rndm = new Random();
            for (int ix = 0; ix < numbers.Length; ix++)
            {
                numbers[ix] = rndm.Next(1, 1000);
            }
            string strRndm = "Random Array: ";
            for (int ix = 0; ix < (numbers.Length - 1); ix++)
            {
                strRndm += numbers[ix].ToString() + ",";
            }
            strRndm += numbers[numbers.Length - 1].ToString();
            //lblRandom.Text = strRnd;
            //MessageBox.Show(strRndm);

            //SELECTION SORT///
            for (int ix = 0; ix < numbers.Length -1; ix++)
            {
                int min = ix;
                for (int j = ix+1; j < numbers.Length; j++)
                {
                    min = j;
                }
                int temp = numbers[ix];
                numbers[ix] = numbers[min];
                numbers[min] = temp;

            }
            string strSorted = "Sorted Array: ";
            for (int ix = 0; ix < numbers.Length - 1; ix++)
            {
                strSorted += numbers[ix].ToString() + ",";
            }
            strSorted += numbers[numbers.Length - 1].ToString();
            // lblSorted.Text = strSorted;
            MessageBox.Show(strSorted, strRndm, MessageBoxButtons.OK);

        }

        private void bttnBubblesort_Click(object sender, EventArgs e)
        {
          

            Form2 secondform = new Form2();
            secondform.Show();
            this.Hide();

            
        }
         

        private void bttnanimation_Click(object sender, EventArgs e)
        { //should open a different form 
            Form3 thirdform = new Form3();
            thirdform.Show();
            this.Hide();
        }

        private void bttnclear_Click(object sender, EventArgs e)
        { //should go back to first options
            bttnsearchingalgo.Visible = true;
            bttnsortingalgo.Visible = true;
            bttnLinearsearch.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnBubblesort.Visible = false;
            bttnclear.Visible = false;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        { //should close with warning 
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string StrTimer = "time taken to complete is: ";
            //MessageBox.Show(StrTimer);
            //timer1.Stop();
            duration++;
            StrTimer = duration.ToString();


        }
    }
}
   