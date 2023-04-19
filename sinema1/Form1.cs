using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,,] sinema = new string[3, 2, 4];
        string[] dizi4 = new string[4] { "K1", "K2", "K3", "K4" };


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "X";
            textBox1.BackColor = Color.Red;



                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "X";
            textBox2.BackColor = Color.Red;
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "X";
            textBox3.BackColor = Color.Red;
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "X";
            textBox4.BackColor = Color.Red;
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.BackColor = Color.Yellow;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 0];
            textBox2.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 1];
            textBox3.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 2];
            textBox4.Text = sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 3];
            if(textBox1.Text == "X")
            {
                textBox1.BackColor= Color.Red;
            }
            else
                textBox1.BackColor = Color.Yellow;
            if (textBox2.Text == "X")
            {
                textBox2.BackColor = Color.Red;
            }
            else
                textBox2.BackColor = Color.Yellow; 
            if (textBox3.Text == "X")
            {
                textBox3.BackColor = Color.Red;
            }
            else
                textBox3.BackColor = Color.Yellow;
            if (textBox4.Text == "X")
            {
                textBox4.BackColor = Color.Red;
            }
            else
                textBox4.BackColor = Color.Yellow;
            button1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.BackColor = Color.Yellow;
                textBox2.BackColor = Color.Yellow;
                textBox3.BackColor = Color.Yellow;
                textBox4.BackColor = Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 0] = textBox1.Text;
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 1] = textBox2.Text;
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 2] = textBox3.Text;
            sinema[comboBox1.SelectedIndex, comboBox2.SelectedIndex, 3] = textBox4.Text;
            //comboBox1.SelectedIndex = -1; //ilk haline getirme
            //comboBox2.SelectedIndex = -1;
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Yellow;
            textBox1.Clear();
            textBox2.Clear();   
            textBox3.Clear();   
            textBox4.Clear();   
            
            button1.Enabled = false;
            MessageBox.Show("Bilet Alınmıştır");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("KAT" + "  " + "SALON" + "  " + "K1" + "  " + "K2" + "  " + " K3 " + "  " + "K4");

            //if (textBox1.BackColor == Color.Yellow)
            //{
            //    listBox1.Items.Add(comboBox1.Text + "             " + comboBox2.Text + "      D");

            //}
            //else
            //{
            //    listBox1.Items.Add(comboBox1.Text + "             " + comboBox2.Text + "      B");
            //}
            //if (textBox2.BackColor == Color.Yellow)
            //{
            //    listBox1.Items.Add(comboBox1.Text + "             " + comboBox2.Text + "             D");
            //}
            //else
            //{
            //    listBox1.Items.Add(comboBox1.Text + "             " + comboBox2.Text + "             B");
            //}
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 4; k++)
                    { 
                        switch (textBox1.Text)
                        {
                            case"null"
                                listBox1.Items.Add(dizi4[k]);
                                break;

                            case 1:
                                listBox1.Items.Add(dizi4[k]);
                                break;

                            case 2:
                                listBox1.Items.Add(dizi4[k]);
                                break;

                            case 3:
                                listBox1.Items.Add(dizi4[k]); ;
                                break;

                        }
                    }
                }
            }

        }

    }
}
