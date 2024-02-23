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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
           
        }//fim entrar

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//fim cadastrar

        private void sair_Click(object sender, EventArgs e)
        {

        }//fim sair
    }
}
