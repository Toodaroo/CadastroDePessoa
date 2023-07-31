using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim do cadastrar pessoa 

        private void label5_Click(object sender, EventArgs e)
        {

        }//fim da cidade

        private void label6_Click(object sender, EventArgs e)
        {

        }//fim do codigo

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(maskedTextBox2.Text);
            string nome = textBox2.Text;
            string telefone = maskedTextBox1.Text;
            string endereco = textBox4.Text;
            string cidade = textBox5.Text;
            string estado = textBox6.Text;

            MessageBox.Show("Código: " + codigo +
                            "\nNome: " + nome +
                            "\nTelefone: " + telefone +
                            "\nEndereço: " + endereco +
                            "\nCidade: " + cidade +
                            "\nEsatdo: " + estado);
        }//fim do botão cadastrar

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim do nome

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim do telefone

        private void label4_Click(object sender, EventArgs e)
        {

        }//fim do endereço

        private void label7_Click(object sender, EventArgs e)
        {

        }//fim do estado

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do resposta nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do resposta telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim do resposta endereço

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//fim do resposta cidade

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//fim do resposta estado

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do resposta codigo

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do codigo

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone
    }//fim da classe
}//fim do projeto
//Todaro
