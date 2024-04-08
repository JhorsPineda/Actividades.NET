using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Text = sumNum1.Text + "+" + sumNum2.Text + "=" + Convert.ToString(int.Parse(sumNum1.Text) + int.Parse(sumNum2.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double peso = 0.00025;
            label3.Text = textBox4.Text+" $COP = "+Convert.ToString(double.Parse(textBox4.Text) * peso + " $USD");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            double Byt = 0.125;
            label4.Text = textBox6.Text +" b = " + Convert.ToString(double.Parse(textBox6.Text) * Byt + " B");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sumNum1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text = sumNum1.Text + "-" + sumNum2.Text + "=" + Convert.ToString(int.Parse(sumNum1.Text) - int.Parse(sumNum2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text = sumNum1.Text +"*"+sumNum2.Text+ "=" + Convert.ToString(int.Parse(sumNum1.Text) * int.Parse(sumNum2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text = sumNum1.Text + "/" + sumNum2.Text + "=" + Convert.ToString(int.Parse(sumNum1.Text) / Double.Parse(sumNum2.Text));
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double peso = 4066.25; peso = Convert.ToInt32(peso);
            label3.Text = textBox1.Text + " $USD = " + Convert.ToString(int.Parse(textBox1.Text) * peso + " $COP");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double kyl = 0.001;
            label4.Text = textBox3.Text + " B = " + Convert.ToString(double.Parse(textBox3.Text) * kyl + " KB");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            double meg = 0.001;
            label4.Text = textBox5.Text + " KB = " + Convert.ToString(double.Parse(textBox5.Text) * meg + " MB");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double gb = 0.001;
            label4.Text = textBox7.Text + " MB = " + Convert.ToString(double.Parse(textBox7.Text) * gb + " GB");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double gb = 0.001;
            label4.Text = textBox2.Text + " GB = " + Convert.ToString(double.Parse(textBox2.Text) * gb + " TB");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
