// Importa namespaces necessários para o código
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Importa namespaces para trabalhar com o banco de dados MySQL
using MySql.Data.MySqlClient;

namespace Projeto___Jogo
{
    public partial class Form_Splash : Form
    {
        private Timer timer_Label; // Declarada variável do Timer

        public Form_Splash()
        {

            InitializeComponent();
            timer_Label = new Timer(); // Cria uma instância do Timer
            timer_Label.Interval = 1500; // Define o intervalo do timer para 2000 milissegundos (2 segundo)
            timer_Label.Tick += Timer_Splash_Tick; // Vincula o método Timer_Splash_Tick ao evento Tick do timer
            timer_Label.Start(); // Inicia o timer
        }

        DialogResult resultado = MessageBox.Show("Você aluno do Centro Paula Souza?", "Confirmação",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Exibe uma caixa de diálogo de confirmação e armazena o resultado

        private int contador = 0; // Variável para controlar o contador de etapas (uma varredura completa do private void Timer_Splash_Tick)
        private void Timer_Splash_Tick(object sender, EventArgs e)
        {


            if (resultado == DialogResult.Yes) // Verifica se o resultado da confirmação é "Sim"
            {

                if (contador == 0)
                {
                    label1.Text = "Carregando bibliotecas"; // Define o texto da label
                }


                else if (contador == 1)
                {
                    label1.Text = ""; // limpa o conteudo já escrito da label
                    label1.Text = "Carregando dados"; // Define o texto da label
                }


                else if (contador == 2)
                {
                    label1.Text = ""; // limpa o conteudo já escrito da label
                    label1.Text = "Estabelecendo conexão com o servidor"; // Define o texto da label
                }


                else if (contador == 3)
                {
                    string Conectar_db = "Server=127.0.0.1; Database=carteirinhas_estudantes; Uid=root; Pwd= ;";
                    // String de conexão que começará o teste com o banco de dados
                    try
                    {
                        using (MySqlConnection Teste_Conexao = new MySqlConnection(Conectar_db))
                        {
                            Teste_Conexao.Open(); // Abre a conexão com o banco de dados

                            label1.Text = ""; // limpa o conteudo já escrito da label
                            label1.Text = "Conexão bem-sucedida!"; // Feedback de que a conexão com o banco foi feita com sucesso
                            Teste_Conexao.Close(); // Fecha a conexão com o banco de dados
                        }
                    }
                    catch (MySqlException)
                    {
                        //A conexão falhou, será exibido uma mensagem de erro
                        timer_Label.Stop(); // Para o timer
                        label1.Text = ""; // limpa o conteudo já escrito da label
                        label1.Text = "Conexão mal-sucedida!"; // Feedback de que a conexão com o banco foi feita sem sucesso
                        
                        DialogResult repete = MessageBox.Show("Erro ao conectar ao estabelecer conexão com o banco de dados", "Conexão mal-sucedida!",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); // Exibe uma caixa de diálogo afirmando que a conexão falhou,
                        //pergunta ao usuário se ele irá querer tentar novamente ou abortar o processo e armazena o resultado na variável "repete"

                        if (repete == DialogResult.Retry) // Se o valor armazenado na variavel "repete" for "Retry" (tentar novamete)
                        {
                            contador = 1; // Retorna o contador par o valor de 1
                            label1.Text = ""; // Limpa todo o conteúdo da label
                            timer_Label.Start(); // Reinicia o timer
                        }
                        else if (repete == DialogResult.Cancel) // Se o conteúdo da variável "repete" for "Cancel"(Cancelar)
                        {
                            this.Close(); // Fecha o formulário
                        }
                        
                    }
                }
                contador++; // Incrementa mais um no contador todas as vezes que a função IF chega ao fim

                if (contador == 5)
                {
                    Form_Login frmLogin = new Form_Login();
                    frmLogin.Show(); // Abre o Form_Login
                    this.Hide(); // Esconde o Form_Splash
                }
            }
            else if (resultado == DialogResult.No)
            {
                timer_Label.Stop(); // Para o timer
                label1.Text = ""; // limpa o conteudo já escrito da label
                label1.Text = "Conexão mal-sucedida!"; // Feedback de que a conexão com o banco foi feita sem sucesso
                MessageBox.Show("Somente estudantes do Centro Paula Souza podem acessá-lo", "Acesso negado!",
                MessageBoxButtons.OK, MessageBoxIcon.Error); ; // Exibe uma caixa de diálogo de confirmação e armazena o resultado
                this.Close(); // Fecha o formulário 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}