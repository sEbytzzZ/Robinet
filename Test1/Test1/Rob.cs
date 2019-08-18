using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robinet
{
    public partial class Rob : Form
    {
        public Rob()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double[,] datee = new double[,] {
                {0 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,35 ,35 ,35 ,35 ,35 ,45 ,45 ,55 ,65 ,80 ,95},
                {0 ,4 ,4 ,4 ,4 ,5 ,6 ,8 ,10 ,12 ,15 ,18 ,25 ,28 ,32 ,40 ,50 ,65 ,80 ,100 ,125 ,150 ,200 ,250 ,300 ,350},
                {0 ,0.1 ,0.2 ,0.4 ,0.6 ,0.93 ,1.33 ,2.1 ,3 ,4 ,5 ,9 ,13 ,13 ,20 ,30 ,40 ,65 ,90 ,140 ,200 ,300 ,420 ,650 ,1000 ,1400},
                {15 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {20 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {25 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {32 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {40 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {50 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {65 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {80 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {100 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {125 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0},
                {150 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0},
                {200 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0 ,0},
                {250 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0 ,0},
                {300 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0},
                {350 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1}
            };

            double[,] date2 = new double[,] {
                {0 ,30 ,30 ,35 ,35 ,35 ,35 ,35 ,35 ,45 ,55 ,65 ,80 ,95 ,120},
                {0 ,32 ,32 ,40 ,50 ,65 ,80 ,100 ,125 ,150 ,200 ,250 ,300 ,350 ,400},
                {0 ,13 ,20 ,30 ,40 ,70 ,110 ,170 ,250 ,390 ,600 ,1000 ,1300 ,2200 ,2900},
                {40 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {50 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {65 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {80 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {100 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {125 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0},
                {150 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0},
                {200 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0 ,0},
                {250 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0 ,0},
                {300 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0 ,0},
                {350 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,0},
                {400 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1}
            };

            int col = 0;
            double kvs= 0, cvs=0;
            int ncols = datee.GetLength(1), nrows = datee.GetLength(0);
            for (int j=0; j<ncols-2; j++)
            {
                if (datee[2, j] <= Form1.kv && datee[2,j+1] >= Form1.kv)
                {
                    kvs = datee[2, j + 1];
                    col = j + 1;
                }
                
            }
            cvs = 1.156 * kvs;
            textBox1.Text = kvs.ToString("0.####");
            textBox5.Text = cvs.ToString("0.####");

            //  cvs:= 1.156 * kvs;

            //      Form1.Edit9.Text:= FloatToStr(kvs);
            //      Form1.Edit13.Text:= FloatToStr(cvs);
            //      Form1.Edit10.Text:= FloatToStr(tabele_rob[1, col]);
            //      Form1.Edit11.Text:= FloatToStr(tabele_rob[2, col]);

            //      Form1.Memo1.Lines.Clear;
            //      for i:= 3 to nrows - 1 do
            //              if (tabele_rob[i, col] = 1) then
            //                   begin

            //               Form1.Memo1.Lines.Add(FloatToStr(tabele_rob[i, 1]));
            //      end;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
