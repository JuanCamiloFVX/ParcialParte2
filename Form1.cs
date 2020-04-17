using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialEjercico2
{
    public partial class Form1 : Form
    {
        private double value1;
        private double value2;
        private int Opcion;
        private string ValueText;
        public Form1()
        {
            InitializeComponent();

            ValueText = "";
        }
        private void getButtonValue(Button button)
        {

            ValueText += button.Text;

            textBoard.Text = ValueText;

        }
        private void getOption(int Value)
        {

            try
            {

                Opcion = Value;
                value1 = Double.Parse(textBoard.Text);
                ValueText = "";
                textBoard.Clear();

            }
            catch (Exception ex)
            {
                textBoard.Text = ex.Message;

            }

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            getButtonValue(button1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            getButtonValue(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getButtonValue(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getButtonValue(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getButtonValue(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getButtonValue(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getButtonValue(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getButtonValue(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getButtonValue(button9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            getButtonValue(button0);
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            int x, s = 1;
            x = Convert.ToInt32(textBoard.Text);
            if (x == 0)
            {
                textBoard.Text = s.ToString();
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    s = s * i;
                    textBoardtwo.Text = s.ToString();

                }
            }
        }

        private void Fibonachi_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoard.Text);
            int numero = 1;
            int temporal = 0;
            int resultado;
            while(temporal <= n+1){

                listBox1.Items.Add(numero.ToString());
                resultado = numero + temporal;
                temporal = numero;
                numero = resultado;
            }

            
        }

        private void Multiplos_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = double.Parse(textBoard.Text);

                textBoardtwo.Text = (value1 * 0, value1 * 1, value1 * 2, value1 * 3, value1 * 4, value1 * 5, value1 * 6, value1 * 7, value1 * 8, value1 * 9).ToString();

            }
            catch (Exception ex)
            {
                textBoard.Text = ex.Message;

            }
        }

        private void Formula_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = double.Parse(textBoard.Text);

                value2 = Math.Pow(value1, 2);

                textBoardtwo.Text = (value2 * 0, value2 * 1, value2 * 2, value2 * 3, value2 * 4, value2 * 5, value2 * 6, value2 * 7, value2 * 8, value2 * 9).ToString();

            }
            catch (Exception ex)
            {
                textBoard.Text = ex.Message;

            }
        }

        private void AC_Click(object sender, EventArgs e)
        {
            ValueText = "";
            textBoard.Clear();
            listBox1.Items.Clear();
            textBoardtwo.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

     