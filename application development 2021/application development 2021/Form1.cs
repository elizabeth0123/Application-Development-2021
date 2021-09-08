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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e);

        }
            public event EventHandler Load;
            btnsortingalgo.Visible = false; 
            bttnsearchingalgo.Visible = false;
            bttnBinarysearch.Visible = false;
            bttnBubblesort.Visible = false;
            bttnLinearsearch.Visible = false;
            bttnSelectionsort.Visible = false;
            bttnstart.Visible = false;
            bttnclear.Visible = false;
        }
    }
}
