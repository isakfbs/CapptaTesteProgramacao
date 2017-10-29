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

        //Coordenadas do canto superior direito do planalto
        string  areaDeExploracaoX = "";
        string  areaDeExploracaoY= "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //compara o valor digitado com o da area de exploracao

                int compareXInicial = Convert.ToInt32(posicaoInicialXTextBox.Text);
                int compareYInicial = Convert.ToInt32(posicaoInicialXTextBox.Text);

                int compareXAreaDeExploracao = Convert.ToInt32(areaDeExploracaoX);
                int compareYAreaDeExploracao = Convert.ToInt32(areaDeExploracaoY);
              
                if (compareXInicial > compareXAreaDeExploracao || compareYInicial > compareYAreaDeExploracao)
                {
                    throw new Exception("A coordenada digitada não pode ultrapassar a da área de expedição");
                }
                else
                {
                    //define a posiçao inicial da sonda
                    string xInicial = posicaoInicialXTextBox.Text;
                    string yInicial = posicaoInicialYTextBox.Text;
                    string direcaoInicial = direcaoComboBox.Text;

                    //define o nome da sonda
                    string nomeDaSonda = nomeDaSondaTextBox.Text;

                    //Instancia uma sonda e a armazena na lista
                    Sonda sonda = new Sonda(xInicial, yInicial, direcaoInicial, nomeDaSonda);
                    sondas.Add(sonda);

                    saidaLabel1.Text = string.Format("Sonda {0} adicionada com sucesso!", sonda.nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta de Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //Habilita botão de iniciar Expedicao e limpa os text box
            iniciarExpedicaoButton.Enabled = true;
            posicaoInicialXTextBox.Clear();
            posicaoInicialYTextBox.Clear();
            nomeDaSondaTextBox.Clear();
            areaDeExploracaoLabel.Focus();
        }

        //inicia o painel, com os botões de adicionar sonda, expedição e de enviar comandos desabilitados
        private void painelForm_Load(object sender, EventArgs e)
        {
            direcaoComboBox.SelectedIndex = 0;
            iniciarExpedicaoButton.Enabled = false;
            enviarButton.Enabled = false;
            posicaoInicialXTextBox.Focus();
            AdicionarSondaButton.Enabled = false;
        }

        private void areaDeExploracaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //Permite apenas números no text box
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
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

        //Libera o envio de comandos para sonda, e desabilita a opçao de adicionar + sondas
        private void iniciarExpedicaoButton_Click(object sender, EventArgs e)
        {
            enviarButton.Enabled = true;
            AdicionarSondaButton.Enabled = false;
            saidaLabel3.Text = " ";
        }

        //Envia os comandos de movimento da sonda

        MovimentarSonda enviarComando = new MovimentarSonda();

        private void enviarButton_Click(object sender, EventArgs e)
        {
            //Quebra a série de instrucões em caracteres
            string instrucao = instrucoesTextBox.Text;
            char[] instrucaoDividida = instrucao.ToCharArray();

            try
            { 
                foreach (Sonda sonda in sondas)
                {
                    foreach (char comando in instrucaoDividida)
                    {
                        enviarComando.realizarMovimento(sonda, comando);
                    }
                    saidaLabel3.Text += string.Format(" Posição final: Sonda | {0} ({1},{2},{3})\n", sonda.nome, sonda.xFinal,sonda.yFinal,sonda.direcaoFinal);           
                }
            }
            catch (Exception ex) {
                MessageBox.Show(""+ex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             areaDeExploracaoX = areaDeExploracaoXTextBox.Text;
             areaDeExploracaoY = areaDeExploracaoYTextBox.Text;
             AdicionarSondaButton.Enabled = true;
             areaDeExploracaoXTextBox.Enabled = false;
             areaDeExploracaoYTextBox.Enabled = false;
             areaDeExploraçãoButton.Enabled = false;
        }

        private void instrucoesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            //permite apenas letras no texbox
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void instrucoesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
