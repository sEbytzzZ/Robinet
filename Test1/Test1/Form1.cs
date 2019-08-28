using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robinet
{
    public partial class Form1 : Form
    {
        public static double kv { get; set; }
        public static short radioButton { get; set; }
        public static double q { get; set; }
        public static double dp { get; set; }
        public static double ro { get; set; }
        public static double v { get; set; }
        public static double p1 { get; set; }
        public static double p2 { get; set; }
        public static double x { get; set; }
        public static double t { get; set; }

        public Form1()
        {
            InitializeComponent();
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
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton11.Visible = false;
            radioButton10.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            button2.Visible = false;
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton = 1;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox4.Text = "";
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
                button2.Visible = false;
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

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton = 2;
                textBox1.Text = "";
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
                button2.Visible = false;
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

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton = 3;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox4.Text = "";
                textBox4.Visible = true;
                textBox6.Text = "";
                textBox6.Visible = true;
                textBox8.Text = "";
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
                button2.Visible = false;
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
                radioButton = 4;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox5.Text = "";
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
                button2.Visible = false;
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
                radioButton = 5;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox5.Text = "";
                textBox5.Visible = true;
                textBox6.Text = "";
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
                button2.Visible = false;
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

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                radioButton = 6;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox7.Text = "";
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
                button2.Visible = false;
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

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                radioButton = 7;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox5.Text = "";
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
                button2.Visible = false;
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

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                radioButton = 8;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox6.Text = "";
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
                button2.Visible = false;
                textBox2.Visible = false;
                textBox6.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
                label14.Visible = false;
            }
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                radioButton = 9;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox5.Text = "";
                textBox5.Visible = true;
                textBox6.Text = "";
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
                button2.Visible = false;
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

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                radioButton = 10;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox7.Text = "";
                textBox7.Visible = true;
                textBox8.Text = "";
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
                button2.Visible = false;
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
                radioButton = 11;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox3.Text = "";
                textBox3.Visible = true;
                textBox5.Text = "";
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
                button2.Visible = false;
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
                radioButton = 12;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox6.Text = "";
                textBox6.Visible = true;
                textBox8.Text = "";
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
                button2.Visible = false;
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
                radioButton = 13;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Visible = true;
                textBox5.Text = "";
                textBox5.Visible = true;
                textBox6.Text = "";
                textBox6.Visible = true;

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
                button2.Visible = false;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            q = 0; dp = 0; ro = 0; v = 0; p1 = 0; p2 = 0; x = 0; t = 0;

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

        private void Button4_Click(object sender, EventArgs e) // Lichid
        {
            if (radioButton1.Visible == true)
                return;

            button4.BackColor = Color.White;
            button5.BackColor = SystemColors.ButtonFace;
            button5.UseVisualStyleBackColor = true;
            button3.BackColor = SystemColors.ButtonFace;
            button3.UseVisualStyleBackColor = true;

            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton11.Visible = false;
            radioButton10.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;

            button2.Visible = false;

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
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (radioButton2.Visible == true)
                return;

            button5.BackColor = Color.White;
            button4.BackColor = SystemColors.ButtonFace;
            button4.UseVisualStyleBackColor = true;
            button3.BackColor = SystemColors.ButtonFace;
            button3.UseVisualStyleBackColor = true;

            radioButton1.Visible = false;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton11.Visible = false;
            radioButton10.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;

            button2.Visible = false;

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
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
        } //Gaz

        private void Button3_Click(object sender, EventArgs e)
        {
            if (radioButton4.Visible == true)
                return;

            button3.BackColor = Color.White;
            button5.BackColor = SystemColors.ButtonFace;
            button5.UseVisualStyleBackColor = true;
            button4.BackColor = SystemColors.ButtonFace;
            button4.UseVisualStyleBackColor = true;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton11.Visible = true;
            radioButton10.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;

            button2.Visible = false;

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
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
        } //Abur
    }
}
