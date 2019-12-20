using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form2 : Form
    {
        public int cont;
        public string button;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = VerificarQuemJoga(button);
            button1.Enabled = false;
            cont++;
            VerificarVencedor();
 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = VerificarQuemJoga(button);
            button8.Enabled = false;
            cont++;
            VerificarVencedor();
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = VerificarQuemJoga(button);
            button3.Enabled = false;
            cont++;
            VerificarVencedor();
   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = VerificarQuemJoga(button);
            button7.Enabled = false;
            cont++;
            VerificarVencedor();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = VerificarQuemJoga(button);
            button5.Enabled = false;
            cont++;
            VerificarVencedor();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = VerificarQuemJoga(button);
            button2.Enabled = false;
            cont++;
            VerificarVencedor();
       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = VerificarQuemJoga(button);
            button6.Enabled = false;
            cont++;
            VerificarVencedor();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = VerificarQuemJoga(button);
            button4.Enabled = false;
            cont++;
            VerificarVencedor();
      
        }

        private void button9_Click(object sender, EventArgs e)
        {   
            button9.Text= VerificarQuemJoga(button);
            button9.Enabled = false;
            cont++; 
            VerificarVencedor();
     

        }
        public string VerificarQuemJoga(string botão)
        {
            if (cont % 2 == 0 || cont == 0)
            {
                botão = "X";
            }
            else
            {
                botão = "O";
            }
            return botão;
        }
        public void VerificarVencedor()
        {
            if((button1.Text == "X" && button7.Text == "X" && button6.Text == "X") || (button1.Text == "X" && button8.Text == "X" && button3.Text == "X") || ( button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button7.Text == "X" && button5.Text == "X" && button2.Text == "X") || (button6.Text == "X" && button4.Text == "X" && button9.Text == "X") || (button6.Text == "X" && button5.Text == "X" && button3.Text == "X") || (button8.Text == "X" && button5.Text == "X" && button4.Text == "X") || (button3.Text == "X" && button2.Text == "X" && button9.Text == "X"))
            {
                MessageBox.Show("Jogador 1 é o Vencedor");
                FechandoJanela();
            }
            else if ((button1.Text == "O" && button7.Text == "O" && button6.Text == "O") || (button1.Text == "O" && button8.Text == "O" && button3.Text == "O") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button7.Text == "O" && button5.Text == "O" && button2.Text == "O") || (button6.Text == "O" && button4.Text == "O" && button9.Text == "O") || (button6.Text == "O" && button5.Text == "O" && button3.Text == "O") || (button8.Text == "O" && button5.Text == "O" && button4.Text == "O") || (button3.Text == "O" && button2.Text == "O" && button9.Text == "O"))
            {
                MessageBox.Show("Jogador 2 é o Vencedor");
                FechandoJanela();
            }
            else if (cont == 9)
            {
                MessageBox.Show("Velha!!!");
                FechandoJanela();
            }
        }
        public void FechandoJanela()
        {
            this.Close();
        }
      
    }
}
