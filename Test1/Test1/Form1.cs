﻿using System;
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
    public partial class Form1 : Form
    {
        public static double kv { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;

                label3.Visible = true;
                label3.Text = "Q";

                label4.Visible = true;
                label4.Text = "m3/h";

                label5.Visible = true;
                label6.Visible = true;

                label7.Visible = true;
                label7.Text = "densitate";

                label8.Visible = true;
                label8.Text = "kg/dm3";
            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;


            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox7.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label5.Visible = true;
                label6.Visible = true;
                label11.Visible = true;
                label15.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox7.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
            }
        }


        private void keypres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            keypres(sender, e);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox4.Text = "";
                textBox4.Visible = true;
                textBox7.Text = "";
                textBox7.Visible = true;
                textBox8.Text = "";
                textBox8.Visible = true;

                label3.Visible = true;
                label3.Text = "Qn";

                label4.Visible = true;
                label4.Text = "m3N/h";
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label7.Text = "densitateN";
                label8.Visible = true;
                label8.Text = "kg/m3N";

                label11.Visible = true;
                label15.Visible = true;
                label12.Visible = true;
                label12.Text = "T";
                label16.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label12.Visible = false;
                label16.Visible = false;
            }
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox6.Visible = true;
                textBox8.Visible = true;

                label3.Visible = true;
                label3.Text = "Qn";

                label4.Visible = true;
                label4.Text = "m3N/h";

                label7.Visible = true;
                label7.Text = "densitateN";
                label8.Visible = true;
                label8.Text = "kg/m3N";

                label10.Visible = true;
                label14.Visible = true;
                label12.Visible = true;
                label16.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox4.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                label14.Visible = false;
                label12.Visible = false;
                label16.Visible = false;
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";

                label5.Visible = true;

                label6.Visible = true;
                label9.Visible = true;
                label13.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox5.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox2.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label10.Visible = true;
                label14.Visible = true;
                label9.Visible = true;
                label13.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                label14.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
            }
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label5.Visible = true;
                label6.Visible = true;
                label9.Visible = true;
                label9.Text = "v2''";
                label13.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox5.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
            }
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                textBox2.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label10.Visible = true;
                label14.Visible = true;
                label9.Visible = true;
                label9.Text = "v2''";
                label13.Visible = true;


            }
            else
            {
                textBox2.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
            }
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                textBox2.Visible = true;
                textBox6.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label10.Visible = true;
                label14.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox6.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                label14.Visible = false;
            }
        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label5.Visible = true;
                label6.Visible = true;


                label11.Visible = true;
                label15.Visible = true;
                label12.Visible = true;
                label12.Text = "x";
                label16.Visible = false;

            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                label12.Visible = false;
            }
        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";

                label5.Visible = true;

                label6.Visible = true;
                label9.Visible = true;
                label9.Text = "vf";
                label13.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox5.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
            }
        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                textBox2.Visible = true;
                textBox6.Visible = true;
                textBox8.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label10.Visible = true;
                label14.Visible = true;
                label12.Visible = true;
                label12.Text = "x";
                label16.Visible = false;

            }
            else
            {
                textBox2.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                label14.Visible = false;
                label12.Visible = false;
            }
        }

        private void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                textBox2.Visible = true;
                textBox6.Visible = true;
                textBox5.Visible = true;

                label3.Visible = true;
                label3.Text = "Qm";

                label4.Visible = true;
                label4.Text = "kg/h";
                label10.Visible = true;
                label14.Visible = true;
                label9.Visible = true;
                label9.Text = "vf";
                label13.Visible = true;


            }
            else
            {
                textBox2.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                label14.Visible = false;

            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double q=0, dp=0, ro=0, v=0, p1=0, p2=0,x=0,t=0;
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
                q = Double.Parse(textBox2.Text);
            if (!String.IsNullOrWhiteSpace(textBox3.Text))
                dp = Double.Parse(textBox3.Text);
            if (!String.IsNullOrWhiteSpace(textBox4.Text))
                ro = Double.Parse(textBox4.Text);
            if (!String.IsNullOrWhiteSpace(textBox5.Text))
                v = Double.Parse(textBox5.Text);
            if (!String.IsNullOrWhiteSpace(textBox6.Text))
                p1 = Double.Parse(textBox6.Text);
            if (!String.IsNullOrWhiteSpace(textBox7.Text))
                p2 = Double.Parse(textBox7.Text);
            if (!String.IsNullOrWhiteSpace(textBox8.Text))
                x=t= Double.Parse(textBox8.Text);

            if (radioButton1.Checked)
            {
                if (q > 0 && dp > 0 && ro > 0)
                {
                    kv = q * Math.Sqrt(ro / dp);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton2.Checked)
            {
                if (q > 0 && dp > 0 && ro > 0 && p2>0 && t>0)
                {
                    kv = q / 514 * Math.Sqrt(ro * t / (p2 * dp));
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton3.Checked)
            {
                if (q > 0 && ro > 0 && p1 > 0 && t > 0)
                {
                    kv = q / 257 * Math.Sqrt(ro * t / p1);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton4.Checked)
            {
                if (q > 0 && dp > 0 && v > 0)
                {
                    kv = q / 31.6 * Math.Sqrt(v / dp);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton5.Checked)
            {
                if (q > 0 && v > 0 && p1 > 0)
                {
                    kv = q / 31.6 * Math.Sqrt(2 * v / p1);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton6.Checked)
            {
                if (q > 0 && dp > 0 && p2 > 0)
                {
                    kv = q / (22.4 * Math.Sqrt(p2 * dp));
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton7.Checked)
            {
                if (q > 0 && dp > 0 && v > 0)
                {
                    kv = q / 31.6 * Math.Sqrt(v / dp);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton8.Checked)
            {
                if (q > 0 && p1 > 0)
                {
                    kv = 2 * q / (22.4 * p1);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton9.Checked)
            {
                if (q > 0 && v > 0 && p1>0)
                {
                    kv = q / 31.6 * Math.Sqrt(2 * v / p1);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton10.Checked)
            {
                if (q > 0 && dp > 0 && p2 > 0 && x>0)
                {
                    kv = q / 22.4 * Math.Sqrt(x / (p2 * dp));
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton11.Checked)
            {
                if (q > 0 && dp > 0 && v > 0)
                {
                    kv = q / 31.6 * Math.Sqrt(v / dp);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton12.Checked)
            {
                if (q > 0 && p1 > 0 && x > 0)
                {
                    kv = 2 * q * Math.Sqrt(x) / (22.4 * p1);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }
            else if (radioButton13.Checked)
            {
                if (q > 0 && v > 0 && p1 > 0)
                {
                    kv = q / 31.6 * Math.Sqrt(2 * v / p1);
                    textBox1.Text = kv.ToString("0.####");
                }
                else textBox1.Text = "Nu se poate calcula!";
            }

            if (kv!=0)
                button2.Visible = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypres(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Rob form = new Rob();
            form.ShowDialog();
        }
    }
}
