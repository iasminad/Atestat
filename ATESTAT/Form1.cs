using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATESTAT
{
    public partial class Form1 : Form
    {
        int punctajr, punctajc, punctajs, punctaji, punctajz, punctaja,maxi;
        String intrebare;
        StreamReader sr;
        string[] raspuns = new string[3]
        {"a.Nu imi place","b.Mi-e indiferent","c.Imi place"};
        int nrintrebare=-1;
        int sw;
       
        public Form1()
        {
            InitializeComponent();
            sr = new StreamReader("intrebari.txt");
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = true;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verificare()
        {
                groupBox1.Visible = true;
                label11.Visible = true;
                if (nrintrebare >= 1 && nrintrebare <= 121)
                {
                    if (nrintrebare == 1 || nrintrebare == 7 || nrintrebare == 13 || nrintrebare == 19 || nrintrebare == 25 || nrintrebare == 31 || nrintrebare == 37 || nrintrebare == 43 || nrintrebare == 49 || nrintrebare == 55 || nrintrebare == 61 || nrintrebare == 67 || nrintrebare == 73 || nrintrebare == 79 || nrintrebare == 85 || nrintrebare == 91 || nrintrebare == 97 || nrintrebare == 103 || nrintrebare == 109 || nrintrebare == 115)
                    {

                        if (radioButton2.Checked == true) punctajr += 1;
                        else if (radioButton3.Checked == true) punctajr += 2;
                    }
                    else if (nrintrebare == 2 || nrintrebare == 8 || nrintrebare == 14 || nrintrebare == 20 || nrintrebare == 26 || nrintrebare == 32 || nrintrebare == 38 || nrintrebare == 44 || nrintrebare == 50 || nrintrebare == 56 || nrintrebare == 62 || nrintrebare == 68 || nrintrebare == 74 || nrintrebare == 80 || nrintrebare == 86 || nrintrebare == 92 || nrintrebare == 98 || nrintrebare == 104 || nrintrebare == 110 || nrintrebare == 116)
                    {

                        if (radioButton2.Checked == true) punctajc += 1;
                        else if (radioButton3.Checked == true) punctajc += 2;
                    }
                    else if (nrintrebare == 3 || nrintrebare == 9 || nrintrebare == 15 || nrintrebare == 21 || nrintrebare == 27 || nrintrebare == 33 || nrintrebare == 39 || nrintrebare == 45 || nrintrebare == 51 || nrintrebare == 57 || nrintrebare == 63 || nrintrebare == 69 || nrintrebare == 75 || nrintrebare == 81 || nrintrebare == 87 || nrintrebare == 93 || nrintrebare == 99 || nrintrebare == 105 || nrintrebare == 111 || nrintrebare == 117)
                    {

                        if (radioButton2.Checked == true) punctajs += 1;
                        else if (radioButton3.Checked == true) punctajs += 2;
                    }
                    else if (nrintrebare == 4 || nrintrebare == 10 || nrintrebare == 16 || nrintrebare == 22 || nrintrebare == 28 || nrintrebare == 34 || nrintrebare == 40 || nrintrebare == 46 || nrintrebare == 52 || nrintrebare == 58 || nrintrebare == 64 || nrintrebare == 70 || nrintrebare == 76 || nrintrebare == 82 || nrintrebare == 88 || nrintrebare == 94 || nrintrebare == 100 || nrintrebare == 106 || nrintrebare == 112 || nrintrebare == 118)
                    {

                        if (radioButton2.Checked == true) punctaji += 1;
                        else if (radioButton3.Checked == true) punctaji += 2;
                    }
                    else if (nrintrebare == 5 || nrintrebare == 11 || nrintrebare == 17 || nrintrebare == 23 || nrintrebare == 29 || nrintrebare == 35 || nrintrebare == 41 || nrintrebare == 47 || nrintrebare == 53 || nrintrebare == 59 || nrintrebare == 65 || nrintrebare == 71 || nrintrebare == 77 || nrintrebare == 83 || nrintrebare == 89 || nrintrebare == 95 || nrintrebare == 101 || nrintrebare == 107 || nrintrebare == 113 || nrintrebare == 119)
                    {

                        if (radioButton2.Checked == true) punctajz += 1;
                        else if (radioButton3.Checked == true) punctajz += 2;
                    }
                    else if (nrintrebare == 6 || nrintrebare == 12 || nrintrebare == 18 || nrintrebare == 24 || nrintrebare == 30 || nrintrebare == 36 || nrintrebare == 42 || nrintrebare == 48 || nrintrebare == 54 || nrintrebare == 60 || nrintrebare == 66 || nrintrebare == 72 || nrintrebare == 78 || nrintrebare == 84 || nrintrebare == 90 || nrintrebare == 96 || nrintrebare == 102 || nrintrebare == 108 || nrintrebare == 114 || nrintrebare >= 120)
                    {

                        if (radioButton2.Checked == true) punctaja += 1;
                        else if (radioButton3.Checked == true) punctaja += 2;
                    }
                }
                label3.Text = "Realist: " + Convert.ToString(punctajr) + " puncte";
                label4.Text = "Conventional: " + Convert.ToString(punctajc) + " puncte";
                label5.Text = "Social: " + Convert.ToString(punctajs) + " puncte";
                label6.Text = "Investigativ: " + Convert.ToString(punctaji) + " puncte";
                label7.Text = "Intreprinzator: " + Convert.ToString(punctajz) + " puncte";
                label8.Text = "Artistic: " + Convert.ToString(punctaja) + " puncte";
        }

        private void afisareintrebare()
        {
            if (!sr.EndOfStream)
            {
                nrintrebare++;
                intrebare = sr.ReadLine();
                label2.Text = intrebare;
                verificare();
                if (nrintrebare == 120)
                {
                    label10.Visible = true;
                    button3.Visible = false;
                    button4.Visible = true;
                    richTextBox1.Visible = true;
                    groupBox1.Visible = false;
                    meniu.Visible = true;
                    label11.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            afisareintrebare();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                if (punctajr >= punctajc && punctajr >= punctajs && punctajr >= punctaji && punctajr >= punctajz && punctajr >= punctaja)
                    maxi = punctajr;
                else if (punctajc > punctajr && punctajc >= punctajs && punctajc >= punctaji && punctajc >= punctajz && punctajc >= punctaja)
                    maxi = punctajc;
                else if (punctajs > punctajr && punctajs > punctajc && punctajs >= punctaji && punctajs >= punctajz && punctajs >= punctaja)
                    maxi = punctajs;
                else if (punctaji > punctajr && punctaji > punctajc && punctaji > punctajs && punctaji >= punctajz && punctaji >= punctaja)
                    maxi = punctaji;
                else if (punctajz > punctajr && punctajz > punctajc && punctajz > punctajs && punctajz > punctaji && punctajz >= punctaja)
                    maxi = punctajz;
                else if (punctaja > punctajr && punctaja > punctajc && punctaja > punctajs && punctaja > punctaji && punctaja > punctajz)
                    maxi = punctaja;
                if (punctajr == maxi)
                {
                    StreamReader sr1 = new StreamReader("Realist.txt");
                    richTextBox1.Text = sr1.ReadToEnd();
                    sr1.Close();
                }
                else if (punctajc == maxi)
                {
                    StreamReader sr1 = new StreamReader("Conventional.txt");
                    richTextBox1.Text = sr1.ReadToEnd();
                    sr1.Close();
                }
                else if (punctajs == maxi)
                {
                    StreamReader sr1 = new StreamReader("Social.txt");
                    richTextBox1.Text = sr1.ReadToEnd();
                    sr1.Close();
                }
                else if (punctaji == maxi)
                {
                    StreamReader sr1 = new StreamReader("Investigativ.txt");
                    richTextBox1.Text = sr1.ReadToEnd();
                    sr1.Close();
                }
                else if (punctajz == maxi)
                {
                    StreamReader sr1 = new StreamReader("Intreprinzator.txt");
                    richTextBox1.Text = sr1.ReadToEnd();
                    sr1.Close();
                }
                else if (punctaja == maxi)
                {
                    StreamReader sr1 = new StreamReader("Artistic.txt");
                    richTextBox1.Text = sr1.ReadToEnd();
                    sr1.Close();
                }
        }

        private void tipulRealistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            StreamReader sr1 = new StreamReader("Realist.txt");
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
        }

        private void tipulConventionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            StreamReader sr1 = new StreamReader("Conventional.txt");
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
        }

        private void tipulSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            StreamReader sr1 = new StreamReader("Social.txt");
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
        }

        private void tipulInvestigativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            StreamReader sr1 = new StreamReader("Investigativ.txt");
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
        }

        private void tipulIntreprinzatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            StreamReader sr1 = new StreamReader("Intreprinzator.txt");
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
        }

        private void tipulArtisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            StreamReader sr1 = new StreamReader("Artistic.txt");
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
        }

        private void rezultateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            button4.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
        }
    }
}
