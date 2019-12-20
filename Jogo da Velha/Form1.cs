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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 JogandoX = new Form2();
           
            JogandoX.Show();

            FechandoJanelaInicial();
        }

        public void FechandoJanelaInicial()
        {
            this.Close();
        }
    }
}
