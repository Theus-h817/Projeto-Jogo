using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Projeto___Jogo
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário
            Form Form_Splash = Application.OpenForms["Form_Splash"]; // Obtém o formulário "Form_Splash" aberto
            if (Form_Splash != null)
            {
                Form_Splash.Close(); // Fecha o formulário "Form_Splash" se estiver aberto
            }
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
        //--------------------------------------------------------------------------INICIA TESTE DE CONEXÃO--------------------------------------------------
            string Conectar_db = "Server=127.0.0.1; Database=carteirinhas_estudantes; Uid=root; Pwd= ;"; // String de conexão com o banco de dados
            using (MySqlConnection conexao = new MySqlConnection(Conectar_db))
            {
                //---------------------------------------------------------------SELECIONA E COMPARA E-MAIL E SENHA DIGITADOS NAS TEXTBOX--------------------------------
                string Dados = "SELECT COUNT(*) FROM cateirinhas_estudante WHERE Email_estudante = @usuario AND Senha_estudante = @senha"; // Consulta SQL para verificar o usuário e senha

                string busca_email = textBox_Email.Text;// Atribui o valor da txtbox a variavel
                string busca_senha = textBox_Senha.Text;// Atribui o valor da txtbox a variavel

                //--------------------------------------------------VERIFICA SE OS VALORES DAS VARIÁVEIS ACIMA E OS RETORNOS DO BANCO DE DADOS COINCIDEM--------------------------------------------
                MySqlCommand comandoSQL1 = new MySqlCommand(Dados, conexao);
                comandoSQL1.Parameters.AddWithValue("@usuario", busca_email); // Define o parâmetro @usuario
                comandoSQL1.Parameters.AddWithValue("@senha", busca_senha); // Define o parâmetro @senha da consulta SQL

                //-------------------------------------------RETORNA O ID DA CONSULTA-----------------------
                string fotos_id = "SELECT ID FROM cateirinhas_estudante WHERE Email_estudante = @usuario AND Senha_estudante = @senha"; // Consulta SQL para obter o ID
                MySqlCommand comandoSQL2 = new MySqlCommand(fotos_id, conexao); // Atribui o valor para o próximo formulário (para a busca da foto correspondente ao ID)
                comandoSQL2.Parameters.AddWithValue("@usuario", busca_email); // Define o parâmetro @usuario
                comandoSQL2.Parameters.AddWithValue("@senha", busca_senha); // Define o parâmetro @senha da consulta SQL


                conexao.Open(); // Abre a conexão com o banco de dados

                int Resultados = Convert.ToInt32(comandoSQL1.ExecuteScalar()); // Executa a consulta SQL e obtém o número de resultados retornados

                object result = comandoSQL2.ExecuteScalar(); // Executa a consulta SQL para obter o ID
                string ID_fotos = result?.ToString(); // Converte o resultado para string

                //-------------------------------------------SE O RESULTADO APÓS O @ FOR REFERENTE A INSTIUIÇÃO, REDIRECIONA PARA O FORMULÁRIO CORRETO-----------------------
                if (Resultados > 0) // Se o banco de dados retornar pelo menos um Resultado
                {
                    //-------------------------------------------SE O RESULTADO APÓS O @ FOR REFERENTE A FATEC, REDIRECIONA PARA O FORMULÁRIO CORRETO-----------------------
                    if (busca_email.EndsWith("@fatec.sp.gov.br")) // Se o email terminar com @fatec.sp.gov.br, irá chamar o formulário da fatec
                    {                                                
                        Form_Fatec frmfatec = new Form_Fatec(); // Login bem-sucedido e transferindo para o form Fatec
                        frmfatec.id = ID_fotos; // Armazena o ID no formulário da Fatec
                        frmfatec.Show(); // Exibe o formulário da Fatec
                        this.Hide(); // Oculta o formulário de login
                    }

                    //-------------------------------------------SE O RESULTADO APÓS O @ FOR REFERENTE A ETEC, REDIRECIONA PARA O FORMULÁRIO CORRETO-----------------------
                    else if (busca_email.EndsWith("@etec.sp.gov.br")) // Se o email terminar com @etec.sp.gov.br, irá chamar o formulário da etec
                    {                        
                        Form_Etec frmetec = new Form_Etec(); // Login bem-sucedido e transferindo para o form Etec
                        frmetec.id = ID_fotos; // Armazena o ID no formulário da Etec
                        frmetec.Show(); // Exibe o formulário da Etec
                        this.Hide(); // Oculta o formulário de login
                    }
                }
                //-------------------------------------------SE O RESULTADO APÓS O @ FOR NULO---------------------------------------------------------------
                else // Se não retornar nada
                {                    
                    MessageBox.Show("Caso o problema persistir, entre em contato\ncom a secretaria de sua instituição",
                    "Usuário ou senha inválidos!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Login falhou
                }

                conexao.Close(); // Fecha a conexão com o banco de dados
            }
        }
        //-------------------------------------------REDIRECIONA A TELA DO DESENVOLEDOR-------------------------------------------
        private void button_Sobre_Click(object sender, EventArgs e) // Abre o formulário com as informações do programa
        {
            Form_Sobre sobre = new Form_Sobre();
            sobre.Show(); // Abre o formulário das informações do software
            //this.Hide(); // Esconde o formulario atual
        }
    }
}
