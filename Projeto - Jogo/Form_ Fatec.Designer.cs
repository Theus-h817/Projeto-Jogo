
namespace Projeto___Jogo
{
    partial class Form_Fatec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fatec));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_entrar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_foto = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label_aluno = new System.Windows.Forms.Label();
            this.label_Instituicao = new System.Windows.Forms.Label();
            this.label_curso = new System.Windows.Forms.Label();
            this.label_RG = new System.Windows.Forms.Label();
            this.label_RA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label_Expedicao = new System.Windows.Forms.Label();
            this.label_Validade = new System.Windows.Forms.Label();
            this.pictureBox_QRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 367);
            this.textBox1.TabIndex = 0;
            // 
            // button_entrar
            // 
            this.button_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrar.Location = new System.Drawing.Point(496, 337);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(96, 32);
            this.button_entrar.TabIndex = 1;
            this.button_entrar.Text = "Exportar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // button_sair
            // 
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(390, 337);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(96, 32);
            this.button_sair.TabIndex = 6;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(450, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer_foto
            // 
            this.timer_foto.Enabled = true;
            this.timer_foto.Interval = 10;
            this.timer_foto.Tick += new System.EventHandler(this.timer_foto_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.IndianRed;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(20, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 19);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "ALUNO:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.IndianRed;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(20, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 19);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "INSTITUIÇÃO DE ENSINO:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.IndianRed;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(20, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 19);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "CURSO:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.IndianRed;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(44, 277);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 19);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "RG:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.IndianRed;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(44, 302);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(30, 19);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "RA:";
            // 
            // label_aluno
            // 
            this.label_aluno.BackColor = System.Drawing.Color.IndianRed;
            this.label_aluno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aluno.ForeColor = System.Drawing.Color.White;
            this.label_aluno.Location = new System.Drawing.Point(80, 200);
            this.label_aluno.Name = "label_aluno";
            this.label_aluno.Size = new System.Drawing.Size(352, 19);
            this.label_aluno.TabIndex = 15;
            this.label_aluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Instituicao
            // 
            this.label_Instituicao.BackColor = System.Drawing.Color.IndianRed;
            this.label_Instituicao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Instituicao.ForeColor = System.Drawing.Color.White;
            this.label_Instituicao.Location = new System.Drawing.Point(188, 225);
            this.label_Instituicao.Name = "label_Instituicao";
            this.label_Instituicao.Size = new System.Drawing.Size(244, 19);
            this.label_Instituicao.TabIndex = 16;
            this.label_Instituicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_curso
            // 
            this.label_curso.BackColor = System.Drawing.Color.IndianRed;
            this.label_curso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_curso.ForeColor = System.Drawing.Color.White;
            this.label_curso.Location = new System.Drawing.Point(80, 251);
            this.label_curso.Name = "label_curso";
            this.label_curso.Size = new System.Drawing.Size(352, 19);
            this.label_curso.TabIndex = 17;
            this.label_curso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_RG
            // 
            this.label_RG.BackColor = System.Drawing.Color.IndianRed;
            this.label_RG.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RG.ForeColor = System.Drawing.Color.White;
            this.label_RG.Location = new System.Drawing.Point(80, 277);
            this.label_RG.Name = "label_RG";
            this.label_RG.Size = new System.Drawing.Size(352, 19);
            this.label_RG.TabIndex = 18;
            this.label_RG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_RA
            // 
            this.label_RA.BackColor = System.Drawing.Color.IndianRed;
            this.label_RA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RA.ForeColor = System.Drawing.Color.White;
            this.label_RA.Location = new System.Drawing.Point(80, 302);
            this.label_RA.Name = "label_RA";
            this.label_RA.Size = new System.Drawing.Size(352, 19);
            this.label_RA.TabIndex = 19;
            this.label_RA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 125);
            this.label1.TabIndex = 40;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkRed;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(20, 344);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 19);
            this.textBox7.TabIndex = 41;
            this.textBox7.Text = "EXPEDIÇÃO:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.DarkRed;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(217, 344);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(73, 19);
            this.textBox8.TabIndex = 42;
            this.textBox8.Text = "VALIDADE:";
            // 
            // label_Expedicao
            // 
            this.label_Expedicao.BackColor = System.Drawing.Color.DarkRed;
            this.label_Expedicao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Expedicao.ForeColor = System.Drawing.Color.White;
            this.label_Expedicao.Location = new System.Drawing.Point(112, 344);
            this.label_Expedicao.Name = "label_Expedicao";
            this.label_Expedicao.Size = new System.Drawing.Size(88, 19);
            this.label_Expedicao.TabIndex = 43;
            this.label_Expedicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Validade
            // 
            this.label_Validade.BackColor = System.Drawing.Color.DarkRed;
            this.label_Validade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Validade.ForeColor = System.Drawing.Color.White;
            this.label_Validade.Location = new System.Drawing.Point(296, 344);
            this.label_Validade.Name = "label_Validade";
            this.label_Validade.Size = new System.Drawing.Size(88, 19);
            this.label_Validade.TabIndex = 44;
            this.label_Validade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_QRCode
            // 
            this.pictureBox_QRCode.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox_QRCode.Location = new System.Drawing.Point(460, 200);
            this.pictureBox_QRCode.Name = "pictureBox_QRCode";
            this.pictureBox_QRCode.Size = new System.Drawing.Size(125, 125);
            this.pictureBox_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_QRCode.TabIndex = 50;
            this.pictureBox_QRCode.TabStop = false;
            // 
            // Form_Fatec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 391);
            this.Controls.Add(this.pictureBox_QRCode);
            this.Controls.Add(this.label_Validade);
            this.Controls.Add(this.label_Expedicao);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label_RA);
            this.Controls.Add(this.label_RG);
            this.Controls.Add(this.label_curso);
            this.Controls.Add(this.label_Instituicao);
            this.Controls.Add(this.label_aluno);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Fatec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form__Escolha_Instituição";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_foto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label_aluno;
        private System.Windows.Forms.Label label_Instituicao;
        private System.Windows.Forms.Label label_curso;
        private System.Windows.Forms.Label label_RG;
        private System.Windows.Forms.Label label_RA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label_Expedicao;
        private System.Windows.Forms.Label label_Validade;
        private System.Windows.Forms.PictureBox pictureBox_QRCode;
    }
}