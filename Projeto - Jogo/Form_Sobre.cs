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

namespace Projeto___Jogo
{
    public partial class Form_Sobre : Form
    {
        public Form_Sobre()
        {
            InitializeComponent();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            //Form_Login login = new Form_Login();
            //login.Show(); // Abre o formulário de login no sistema
            this.Close(); // Esconde o formulario atual
        }
    }
}
