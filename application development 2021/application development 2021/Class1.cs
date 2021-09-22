using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace application_development_2021
{
    class Class1 : Interface1
    { 
        private bool _sortedArray = false;
        private int[] OgArray;
        private Graphics g;
        private int MaxVal;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
       
        public void DoWork(int[] OgArray_In, Graphics g_In, int MaxVal_In)
        {
            OgArray = OgArray_In;
            g = g_In;
            MaxVal = MaxVal_In;

            while (!_sortedArray)
            {
                for (int i = 0; i < OgArray.Count() -1; i++)
                {
                    if (OgArray [i] > OgArray[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }
              _sortedArray = IsSorted();
            }

        }

        private bool IsSorted()
        {
            for (int i = 0; i < OgArray.Count() - 1; i++)
            {
                if (OgArray[i] > OgArray[i + 1]) return false;
            }
            return true;
        }

        private void Swap(int i, int p)
        {
            int temp = OgArray[i];
            OgArray[i] = OgArray[i + 1];
            OgArray[i + 1] = temp;

            g.FillRectangle(BlackBrush, i, 0, 1, MaxVal);
            g.FillRectangle(BlackBrush, p, 0, 1, MaxVal);

            g.FillRectangle(WhiteBrush, i, MaxVal - OgArray[i], 1, MaxVal);
            g.FillRectangle(WhiteBrush, p, MaxVal - OgArray[p], 1, MaxVal);
        }

      
    }
}
