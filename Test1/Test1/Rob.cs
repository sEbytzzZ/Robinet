﻿using System;
using System.Windows.Forms;

namespace Robinet
{
    public partial class Rob : Form
    {
        public Rob()
        {
            InitializeComponent();
        }

        private double kvs = 0;

        private void radioChecked(double[,] datas)
        {
            int col = 0;
            double cvs = 0;
            int ncols = datas.GetLength(1), nrows = datas.GetLength(0);
            for (int j = 0; j < ncols - 2; j++)
            {
                if (datas[2, j] <= Form1.kv && datas[2, j + 1] >= Form1.kv)
                {
                    kvs = datas[2, j + 1];
                    col = j + 1;
                }

            }
            cvs = 1.156 * kvs;
            textBox1.Text = kvs.ToString("0.####");
            textBox5.Text = cvs.ToString("0.####");

            textBox2.Text = datas[0, col].ToString();
            textBox3.Text = datas[1, col].ToString();

            richTextBox1.Clear();
            for (int i = 2; i < nrows; i++)
            {
                if (datas[i, col] == 1)
                    richTextBox1.AppendText(datas[i, 0].ToString() + "\r\n");
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double[,] datas = new double[,] {
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

            radioChecked(datas);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double[,] datas = new double[,] {
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
            radioChecked(datas);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double[,] datas = new double[,]{
                {0 ,30 ,30 ,35 ,35 ,45 ,55 ,65 ,80},
                {0 ,25 ,30 ,80 ,100 ,150 ,200 ,250 ,300},
                {0 ,11 ,34 ,92 ,140 ,325 ,500 ,835 ,1100},
                {25 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                {50 ,0 ,1 ,0 ,0 ,0 ,0 ,0 ,0},
                {80 ,0 ,0 ,1 ,0 ,0 ,0 ,0 ,0},
                {100 ,0 ,0 ,0 ,1 ,0 ,0 ,0 ,0},
                {150 ,0 ,0 ,0 ,0 ,1 ,0 ,0 ,0},
                {200 ,0 ,0 ,0 ,0 ,0 ,1 ,0 ,0},
                {250 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,0},
                {300 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1}
            };

            radioChecked(datas);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double[,] datas = new double[,]{
                { 0 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,30 ,35 ,35 ,35 ,35 ,35 ,45 ,45 ,55 ,65 ,80},
                { 0 ,4 ,4 ,4 ,4 ,4 ,5 ,6 ,8 ,10 ,12 ,15 ,18 ,20 ,22 ,25 ,32 ,40 ,50 ,65 ,80 ,100 ,125 ,150 ,200 ,250 ,300},
                { 0 ,0.05 ,0.1 ,0.2 ,0.4 ,0.6 ,0.93 ,1.33 ,2.1 ,3.6 ,4.8 ,7 ,9 ,11 ,15 ,16 ,24 ,36 ,50 ,80 ,110 ,170 ,240 ,390 ,500 ,800 ,120},
                { 15 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 20 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 25 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 32 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 40 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 50 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 65 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0 ,0},
                { 80 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,0},
                { 100 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,0},
                { 150 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,1 ,1 ,0 ,0 ,0},
                { 200 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0 ,0},
                { 250 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1 ,0},
                { 300 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,1 ,1}
            };

            radioChecked(datas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double qmax = 0;
            switch (Form1.radioButton)
            {
                case 1:
                    qmax = kvs * Math.Sqrt(Form1.dp / Form1.ro);
                    break;
                case 2:
                    qmax = kvs * 514 * Math.Sqrt(Form1.p2 * Form1.dp / (Form1.ro * Form1.t));
                    break;
                case 3:
                    qmax = kvs * 257 * Math.Sqrt(Form1.p1 / (Form1.ro * Form1.t));
                    break;
                case 4:
                    qmax = kvs * Math.Sqrt(Form1.dp / Form1.ro);
                    break;
                case 5:
                    qmax = kvs * Math.Sqrt(Form1.dp / Form1.ro);
                    break;
                case 6:
                    qmax = kvs * Math.Sqrt(Form1.dp / Form1.ro);
                    break;
                case 7:
                    qmax = kvs * Math.Sqrt(Form1.dp / Form1.ro);
                    break;
                case 8:
                    qmax = kvs * Math.Sqrt(Form1.dp / Form1.ro);
                    break;
            }

            textBox4.Text = qmax.ToString("0.####");

            //if domeniu = 1 then qmax:= kvs * sqrt(dp / ro);
            //if domeniu = 2 then qmax:= kvs * 514 * sqrt(p2 * dp / (ro * t));
            //if domeniu = 3 then qmax:= kvs * 257 * sqrt(p1 / (ro * t));
            //if domeniu = 4 then qmax:= kvs * 31.6 * sqrt(dp / v);
            //if domeniu = 5 then qmax:= kvs * 31.6 * sqrt(p1 / (2 * v));
            //if domeniu = 6 then qmax:= kvs * 22.4 * sqrt(p2 * dp);
            //if domeniu = 7 then qmax:= kvs * 31.6 * sqrt(dp / v);
            //if domeniu = 8 then qmax:= kvs * 22.4 * p1 / 2;
            //if domeniu = 9 then qmax:= kvs * 31.6 * sqrt(p1 / (2 * v));
            //if domeniu = 10 then qmax:= kvs * 22.4 * sqrt(p2 * dp / x);
            //if domeniu = 11 then qmax:= kvs * 31.6 * sqrt(dp / v);
            //if domeniu = 12 then qmax:= kvs * 22.4 * p1 / (2 * sqrt(x));
            //if domeniu = 13 then qmax:= kvs * 31.6 * sqrt(p1 / (2 * v));
            //Edit12.Text:= FloatToStr(round(qmax * 10000) / 10000);
        }
    }
}
