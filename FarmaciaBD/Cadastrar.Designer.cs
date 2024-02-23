namespace FarmaciaBD
{
    partial class Cadastrar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.respostaNome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.telefoneResposta = new System.Windows.Forms.MaskedTextBox();
            this.rgResposta = new System.Windows.Forms.MaskedTextBox();
            this.cpfResposta = new System.Windows.Forms.MaskedTextBox();
            this.avançar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.cpf2 = new System.Windows.Forms.Label();
            this.rg2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.codigoResposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Informe algumas informações abaixo: ";
            // 
            // respostaNome
            // 
            this.respostaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respostaNome.Location = new System.Drawing.Point(142, 147);
            this.respostaNome.Name = "respostaNome";
            this.respostaNome.Size = new System.Drawing.Size(185, 35);
            this.respostaNome.TabIndex = 2;
            this.respostaNome.TextChanged += new System.EventHandler(this.respostaNome_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(142, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 35);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(142, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 35);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(128, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 35);
            this.textBox4.TabIndex = 8;
            // 
            // telefoneResposta
            // 
            this.telefoneResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneResposta.Location = new System.Drawing.Point(142, 194);
            this.telefoneResposta.Mask = "(99) 99 99999-9999";
            this.telefoneResposta.Name = "telefoneResposta";
            this.telefoneResposta.Size = new System.Drawing.Size(185, 35);
            this.telefoneResposta.TabIndex = 9;
            this.telefoneResposta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefoneResposta_MaskInputRejected);
            // 
            // rgResposta
            // 
            this.rgResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgResposta.Location = new System.Drawing.Point(142, 247);
            this.rgResposta.Mask = "99 999 999-9";
            this.rgResposta.Name = "rgResposta";
            this.rgResposta.Size = new System.Drawing.Size(185, 35);
            this.rgResposta.TabIndex = 10;
            this.rgResposta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.rgResposta_MaskInputRejected);
            // 
            // cpfResposta
            // 
            this.cpfResposta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpfResposta.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfResposta.Location = new System.Drawing.Point(128, 294);
            this.cpfResposta.Mask = "999 999 999-99";
            this.cpfResposta.Name = "cpfResposta";
            this.cpfResposta.Size = new System.Drawing.Size(199, 40);
            this.cpfResposta.TabIndex = 11;
            this.cpfResposta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpfResposta_MaskInputRejected);
            // 
            // avançar
            // 
            this.avançar.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avançar.Location = new System.Drawing.Point(128, 376);
            this.avançar.Name = "avançar";
            this.avançar.Size = new System.Drawing.Size(129, 50);
            this.avançar.TabIndex = 12;
            this.avançar.Text = "Avançar";
            this.avançar.UseVisualStyleBackColor = true;
            this.avançar.Click += new System.EventHandler(this.avançar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefone: ";
            this.label2.UseMnemonic = false;
            
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nome.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nome.Location = new System.Drawing.Point(28, 147);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(78, 33);
            this.nome.TabIndex = 16;
            this.nome.Text = "Nome:";
            this.nome.UseMnemonic = false;
            // 
            // cpf2
            // 
            this.cpf2.AutoSize = true;
            this.cpf2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cpf2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cpf2.Location = new System.Drawing.Point(26, 300);
            this.cpf2.Name = "cpf2";
            this.cpf2.Size = new System.Drawing.Size(73, 33);
            this.cpf2.TabIndex = 17;
            this.cpf2.Text = "CPF: ";
            this.cpf2.UseMnemonic = false;
            // 
            // rg2
            // 
            this.rg2.AutoSize = true;
            this.rg2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rg2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rg2.Location = new System.Drawing.Point(28, 249);
            this.rg2.Name = "rg2";
            this.rg2.Size = new System.Drawing.Size(61, 33);
            this.rg2.TabIndex = 18;
            this.rg2.Text = "RG: ";
            this.rg2.UseMnemonic = false;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.codigo.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(28, 99);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(88, 33);
            this.codigo.TabIndex = 19;
            this.codigo.Text = "Código:";
            // 
            // codigoResposta
            // 
            this.codigoResposta.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoResposta.Location = new System.Drawing.Point(142, 99);
            this.codigoResposta.Name = "codigoResposta";
            this.codigoResposta.Size = new System.Drawing.Size(185, 38);
            this.codigoResposta.TabIndex = 20;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.codigoResposta);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.rg2);
            this.Controls.Add(this.cpf2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avançar);
            this.Controls.Add(this.cpfResposta);
            this.Controls.Add(this.rgResposta);
            this.Controls.Add(this.telefoneResposta);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.respostaNome);
            this.Controls.Add(this.textBox1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox respostaNome;
        private System.Windows.Forms.TextBox textBox2;
        
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        
        private System.Windows.Forms.MaskedTextBox telefoneResposta;
        private System.Windows.Forms.MaskedTextBox rgResposta;
        private System.Windows.Forms.MaskedTextBox cpfResposta;
        private System.Windows.Forms.Button avançar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label cpf2;
        private System.Windows.Forms.Label rg2;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox codigoResposta;
    }
}