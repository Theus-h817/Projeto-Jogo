using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



//Desenvolvedor:
//Matheus Henrique Cella Carrasco

//Formação:
//Estudante do segundo semestre de Análise e Desenvolvimento de Sistemas

//Data de Desenvolvimento:
//Concluido em 26/05/2023
//Ultima revisão em 12/06/20223

//Créditos das Imagens:
//Todas as imagens utilizadas neste software são fornecidas pelo Centro Paula Souza (CPS) e do Governo do Estado de São Paulo

//Disciplina e Professor:
//Este trabalho foi desenvolvido para a disciplina de Programação, ministrada pelo professor Ronnie Rillo.

//Agradecimentos:
//Ao professor Ronnie Rillo por orientar e fornecer conhecimentos técnicos durante o desenvolvimento deste projeto.



namespace Projeto___Jogo
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Splash());
        }
    }
}
