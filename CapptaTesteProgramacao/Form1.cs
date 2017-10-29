using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapptaTesteProgramacao
{
    public partial class painelForm : Form
    {
        public painelForm()
        {
            InitializeComponent();
        }

        //Lista que guarda as sondas que o usúario adicionar
        List<Sonda> sondas = new List<Sonda>();

        private void button1_Click(object sender, EventArgs e)
        {
            string posicaoInicial = posicaoInicialXTextBox.Text;
            string nomeDaSonda = nomeDaSondaTextBox.Text;

            Sonda sonda = new Sonda(posicaoInicial,nomeDaSonda);

            sondas.Add(sonda);

            iniciarExpedicaoButton.Enabled = true;
            posicaoInicialXTextBox.Clear();
            nomeDaSondaTextBox.Clear();
            areaDeExploracaoLabel.Focus();
        }

        private void painelForm_Load(object sender, EventArgs e)
        {
            iniciarExpedicaoButton.Enabled = false;
            enviarButton.Enabled = false;
            posicaoInicialXTextBox.Focus();
        }

        private void areaDeExploracaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   

            //Permite apenas números no text box
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void areaDeExploracaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void posicaoInicialXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite apenas números no text box
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void posiçaoInicialYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite apenas números no text box
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void areaDeExploracaoYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite apenas números no text box
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
