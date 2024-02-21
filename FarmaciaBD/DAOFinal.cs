using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FarmaciaBD
{
    public class DAOFinal
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public int contador;
        public int i;
        public int[] codigo;
        public string[] nome;
    }//fim da classe
}//fim do projeto
