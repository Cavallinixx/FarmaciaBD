using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaBD
{
    public partial class menuEntrar : Form
    {
        public menuEntrar()
        {
            InitializeComponent();
        }

        private void menuEntrar_Load(object sender, EventArgs e)
        {

        }//fim menu entrar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da resposta CPF

        private void voltar_Click(object sender, EventArgs e)
        {

        }//fim do voltar

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//fim do cadastrar
    
    }//fim do metodo 
}//fim do projeto 
