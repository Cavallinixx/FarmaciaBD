using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaBD
{
    public partial class Cadastrar : Form
    {
        DAOFinal bd;
        
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAOFinal();
        }
        private void codigoResposta_TextChanged(object sender, EventArgs e)
        {

        }// fim codigo resposta
 
        private void respostaNome_TextChanged(object sender, EventArgs e)
        {

        }//fim nome

        private void telefoneResposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim telefone 

        private void rgResposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim rg resposta

        private void cpfResposta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim cpf
        private void avançar_Click(object sender, EventArgs e)
        {

            int cod = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string tel = telefoneResposta.Text;
            string rg = rgResposta.Text;
            string cpf = cpfResposta.Text;

            bd.Inserir(cod, name, tel, rg, cpf);//Inserindo no BD

            //Limpando os campos
            codigo.Text = "";
            nome.Text = "";
            telefoneResposta.Text = "";
            rgResposta.Text = "";
            cpfResposta.Text = "";
        }//fim do avançar

        private void codigoResposta_TextChanged_1(object sender, EventArgs e)
        {

        }//fim codigo resposta

        
    }//fim do metodo
}//fim do projeto 
