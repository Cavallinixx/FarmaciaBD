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
        public string[] telefone;
        public string[] rg;
        public string[] cpf;
        public DAOFinal()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=farmaciati18n;Uid=root;Password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente             
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                conexao.Close();
            }//fim do catch
        }//fim do construtor

        public void Inserir(int codigo, string nome, string telefone, string rg, string cpf)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + rg + "','" + cpf + "')";
            sql = "insert into pessoa(codigo, nome, telefone, rg, cpf) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método

        public int ConsultarTamanhoBD()
        {
            return contador;
        }//fim do selecionar

        public void PreencherVetor()
        {
            string query = "select * from pessoa";//Coletar os dados do BD

            //Instanciar
            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.rg = new string[100];
            this.cpf = new string[100];

            //Preencher com valores iniciais
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                telefone[i] = "";
                rg[i] = "";
                cpf[i] = "";
            }//fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                rg[i] = leitura["rg"] + "";
                cpf[i] = leitura["cpf"] + "";
                i++;
                contador++;

            }//Fim do while

            //Fechar a leitura de dados no banco
            leitura.Close();
        }//fim do método preencher

        public int[] ConsultarCodigo()
        {
            PreencherVetor();
            return codigo;
        }//fim do método
        public string[] ConsultarNome()
        {
            PreencherVetor();
            return nome;
        }//fim do método

        public string[] ConsultarTelefone()
        {
            PreencherVetor();
            return telefone;
        }//fim do método

        public string[] ConsultarRg()
        {
            PreencherVetor();
            return rg;
        }//fim do método

        public string[] ConsultarCpf()
        {
            PreencherVetor();
            return cpf;
        }//fim do método
    }//fim da classe
}//fim do projeto
