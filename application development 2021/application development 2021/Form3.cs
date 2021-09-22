using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace application_development_2021
{
    public partial class Form3 : Form
        
    {
        int[] OgArray;
        Graphics g;
        public Form3()
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //should give error box on close with box selections
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

        private void bttnHomepage_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Hide();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            int NumEntries = panel1.Width;
            int MaxVal = panel1.Height;
            OgArray = new int[NumEntries];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, NumEntries, MaxVal);
            Random Rndm = new Random();
            for (int i = 0; i < NumEntries; i++)
            {
                OgArray[i] = Rndm.Next(0, MaxVal);
            }
            for (int i = 0; i < NumEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, MaxVal - OgArray[i], 1, MaxVal);
            }

        }

        private void bttnSort_Click(object sender, EventArgs e)
        {
            Interface1 se = new Class1();
            se.DoWork(OgArray, g, panel1.Height);
        }

     
    }
}
