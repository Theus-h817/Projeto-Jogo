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

// Importa namespace para trabalhar com fluxos de arquivo
using System.IO;

// Importa namespaces para gerar QR Code
using ZXing;
using ZXing.QrCode;

// Importa namespaces para trabalhar com geração de PDF
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto___Jogo
{
    public partial class Form_Etec : Form
    {
        public string id { get; set; } // Propriedade para armazenar o ID entre Forms

        public Form_Etec()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dados_conexao = "Server=127.0.0.1; " +
            "Database=carteirinhas_estudantes; Uid=root; Pwd= ;"; // String de conexão com o banco de dados

            //------------------------------------------------------------CONSULTA DE DADOS----------------------------------------------------------------------------------------
            using (MySqlConnection conexao = new MySqlConnection(dados_conexao))
            {
                string informacoes = "SELECT Nome_institucao, Curso_estudante, Nome_estudante, " +
                "RG_estudante, RA_estudante, Foto_estudante, Expedicao_carterinha, " +
                "Validade_carteirinha FROM cateirinhas_estudante WHERE id = @id"; // Query para obter as informações do estudante com base no ID
                MySqlCommand comandoSQL = new MySqlCommand(informacoes, conexao);
                comandoSQL.Parameters.AddWithValue("@id", id); // Consulta SQL para obter informações do estudante com base no ID

                conexao.Open(); //Abre a conexão com o banco de dados

                using (MySqlDataReader Resultados = comandoSQL.ExecuteReader()) // Executa a consulta e obtém os resultados
                {

                    //------------------------------------------------------------BUSCA E MOSTRAGEM DE RESULTADOS--------------------------------------------------------------------------
                    if (Resultados.Read()) // Verifica se houve retorno de resultados
                    {
                        string nome_Instituicao = Resultados["Nome_institucao"].ToString(); // Obtém o valor da coluna "Nome_institucao" e converte para string
                        string curso_Estudante = Resultados["Curso_estudante"].ToString(); // Obtém o valor da coluna "Curso_estudante" e converte para string
                        string nome_Estudante = Resultados["Nome_estudante"].ToString(); // Obtém o valor da coluna "Nome_estudante" e converte para string
                        string RG = Resultados["RG_estudante"].ToString(); // Obtém o valor da coluna "RG_estudante" e converte para string
                        string RA = Resultados["RA_estudante"].ToString(); // Obtém o valor da coluna "RA_estudante" e converte para string
                        DateTime Expedicao = Convert.ToDateTime(Resultados["Expedicao_carterinha"]); // Obtém o valor da coluna "Expedicao_carterinha" e converte para DateTime
                        DateTime Validade = Convert.ToDateTime(Resultados["Validade_carteirinha"]); // Obtém o valor da coluna "Validade_carteirinha" e converte para DateTime

                        label_instituicao.Text = nome_Instituicao; // Atribui o valor da variável à label correspondente
                        label_curso.Text = curso_Estudante; // Atribui o valor da variável à label correspondente
                        label_aluno.Text = nome_Estudante; // Atribui o valor da variável à label correspondente
                        label_RG.Text = RG; // Atribui o valor da variável à label correspondente
                        label_RA.Text = RA; // Atribui o valor da variável à label correspondente
                        label_Expedicao.Text = Expedicao.ToString("dd/MM/yyyy"); // Formata a data para o formato "dd/MM/yyyy" e atribui o valor à label correspondente
                        label_Validade.Text = Validade.ToString("dd/MM/yyyy"); // Formata a data para o formato "dd/MM/yyyy" e atribui o valor à label correspondente

                        //------------------------------------------------------------QR CODE-----------------------------------------------------------------------------------------------------      
                        string qrcode = $"{"Válido apenas se acompanhado de documento com foto"}\n" +
                            $"{"Instituição de ensino: "} {label_instituicao.Text}\n" +
                            $"{"Curso: "}{label_curso.Text}\n" +
                            $"{"Aluno: "}{label_aluno.Text}\n" +
                            $"{"RG: "}{label_RG.Text}\n" +
                            $"{"RG: "}{label_RA.Text}\n" +
                            $"{"Data de expedição: "}{label_Expedicao.Text}\n" +
                            $"{"Data de validade: "}{label_Validade.Text}"; // Atribui valores entre {} á string "qrcode" 
                        var qrCodeWriter = new BarcodeWriter(); // Cria uma instância do BarcodeWriter
                        qrCodeWriter.Format = BarcodeFormat.QR_CODE; // Define o formato do código de barras como QR Code
                        qrCodeWriter.Options = new QrCodeEncodingOptions
                        {
                            DisableECI = true, // Desativa a codificação ECI
                            CharacterSet = "UTF-8", // Define o conjunto de caracteres como UTF-8
                            Width = 0, // Define a largura do QR Code em pixels
                            Height = 0 // Define a altura do QR Code em pixels
                        };
                        Bitmap qrCode_Imagem = new Bitmap(qrCodeWriter.Write(qrcode)); // Gera a imagem do QR Code usando o texto fornecido
                        pictureBox_QRCode.Image = qrCode_Imagem; // Atribui a imagem do QR Code à propriedade Image da PictureBox_QRCode



                        //------------------------------------------------------------MOSTRAR A FOTO DO ESTUDANTE-------------------------------------------------------------
                        try // Se o banco de dados retornar uma imagem 
                        {
                            byte[] Dados_da_foto = (byte[])Resultados["Foto_estudante"]; // Obtém os dados da imagem em formato byte[] da foto resultante

                            using (MemoryStream Foto = new MemoryStream(Dados_da_foto)) // Cria um MemoryStream com os bytes da imagem
                            {

                                pictureBox_Foto.Image = System.Drawing.Image.FromStream(Foto); // Define e carrega a imagem do pictureBox a partir do MemoryStream
                            }
                        }

                        catch (ArgumentException) // Se o banco não retornar nenhum resultado válido
                        {
                            MessageBox.Show("Entre em contato com sua intituição de ensino",
                            "Foto não encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostra uma notificação indicando que ouve falha ao buscar a imagem
                            button_entrar.Enabled = false; // Desabilita o botão de exportação de documento
                            pictureBox_QRCode.Image = null; // Desabilita a exibição do QR Code
                            // A foto é essencial para a exportação da carteirinha, sem ela é impossível exportar
                        }
                    }
                }
                conexao.Close(); // Fecha a conexão com o banco de dados
            }
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Form_Login frmlogin = new Form_Login(); // Retorna para a tela de login
            frmlogin.Show(); // Exibe o formulário de Login
            this.Close(); // fecha o formulário Etec
        }


//------------------------------------------------------------CLIQUE PARA A FOTO APARECER--------------------------------------------------------------
        private void timer_foto_Tick(object sender, EventArgs e)
        {
            timer_foto.Stop(); // Para o timer
            pictureBox1_Click(sender, e); // Chama o método de clique do PictureBox                
        }



//-------------------------------------------------------TRANSFORMANDO O FORM PARA IMAGEM (.PNG) E PREPARANDO PDF----------------------------------------------------------
        private void button_entrar_Click(object sender, EventArgs e)
        {
            // Captura a imagem do formulário
            Bitmap Print_do_Form = CaptureFormScreenshot(); // Capturar a imagem do formulário no estado atual

            // Cria um documento PDF
            Document gerar_PDF = new Document(); // Cria uma instância para representar o documento PDF


            // Define o nome e o caminho do arquivo PDF de saída
            string nomeArquivo = "Carteirinha.pdf"; // Define o nome do arquivo PDF
            string caminhoArquivo = GetSaveFilePath(nomeArquivo); //Obtém o caminho do arquivo de destino do PDF


            if (!string.IsNullOrEmpty(caminhoArquivo)) //Se a string caminhoArquivo estiver com QUALQUER coisa...
            {
                // Cria um objeto FileStream (suporte a operações de leitura e gravação síncronas e assíncronas) para escrever o documento PDF
                using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    // Cria uma instância do escritor do documento PDF
                    PdfWriter writer = PdfWriter.GetInstance(gerar_PDF, fs); // Cria um escritor do PDF e associa o documento ao FileStream

                    // Abre o documento PDF
                    gerar_PDF.Open(); // Abre o documento PDF para escrita

                    // Cria uma imagem iTextSharp a partir do bitmap capturado
                    iTextSharp.text.Image imagem_Printada = iTextSharp.text.Image.GetInstance(Print_do_Form,
                    System.Drawing.Imaging.ImageFormat.Png);  //Atribui uma instância da imagem capturada do form para a imagem_Printada


                    // Define o tamanho da imagem como o tamanho da página, ajustando-a para caber dentro dos limites da página
                    imagem_Printada.ScaleToFit(gerar_PDF.PageSize.Width - gerar_PDF.LeftMargin - gerar_PDF.RightMargin,
                    gerar_PDF.PageSize.Height - gerar_PDF.TopMargin - gerar_PDF.BottomMargin); // Redimensiona a imagem_Printada na página do PDF


                    // Define a posição da imagem no centro da página
                    imagem_Printada.SetAbsolutePosition((gerar_PDF.PageSize.Width - imagem_Printada.ScaledWidth) / 2,
                    (gerar_PDF.PageSize.Height - imagem_Printada.ScaledHeight) / 2); // Enquadra a imagem no centro da página do PDF

                    
                    gerar_PDF.Add(imagem_Printada); // Adiciona a imagem ao documento PDF

                    
                    gerar_PDF.Close(); // Fecha o documento PDF com a imagem do form ja inserida e enquadrada

                    MessageBox.Show("Formulário exportado com sucesso para o arquivo PDF!"); // Exibe uma mensagem de sucesso
                    
                    System.Diagnostics.Process.Start(caminhoArquivo); // Abre o arquivo PDF com o programa padrão do sistema
                }
            }
        }


//-------------------------------------------------------------------REALIZANDO O TRATAMENTO DA IMAGEM ------------------------------------------------------------------
        private Bitmap CaptureFormScreenshot()
        {
            // Captura a imagem do formulário
            Bitmap print = new Bitmap(this.Width, this.Height); // Cria um bitmap com o tamanho do formulário
            Graphics dados_print = Graphics.FromImage(print); // Cria um objeto dados_print a partir do bitmap
            dados_print.CopyFromScreen(this.Location, Point.Empty, this.Size); // Copia o conteúdo da tela (form) para o bitmap

            return print; // Retorna o bitmap capturado
        }

//--------------------------------------------------INSERINDO A IMAGEM NO PDF, TRANFORMANDO-A ESALVANDO O ARQUIVO --------------------------------------------------------
        private string GetSaveFilePath(string Carteirinha)
        {  
            using (SaveFileDialog Diretorio_Escolha = new SaveFileDialog()) // Exibe uma caixa de diálogo para o usuário selecionar o nome e o diretório de destino
            {
                Diretorio_Escolha.FileName = Carteirinha; // Define o nome padrão do arquivo (que pode ser trocado para o da preferência do usuário)
                Diretorio_Escolha.Filter = "Arquivos PDF (*.pdf)|*.pdf|Todos os arquivos (*.*)|*.*"; // Define os filtros de extensão de arquivo (lado direito da textbox de nome na caixa de diálogo)
                if (Diretorio_Escolha.ShowDialog() == DialogResult.OK) // Se o botão OK for clicado...
                {
                    return Diretorio_Escolha.FileName; // Retorna o caminho e o nome do arquivo selecionado pelo usuário
                }
            }

            return null; // Retorna null caso o usuário tenha cancelado a seleção do arquivo (botão cancelar na caixa de diálogo)
        }

    }
}