namespace FarmaciaBD
{
    partial class PlanoSaude
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
            this.sim = new System.Windows.Forms.Button();
            this.nao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sim
            // 
            this.sim.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim.Location = new System.Drawing.Point(12, 222);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(149, 55);
            this.sim.TabIndex = 0;
            this.sim.Text = "Sim";
            this.sim.UseVisualStyleBackColor = true;
            this.sim.Click += new System.EventHandler(this.sim_Click);
            // 
            // nao
            // 
            this.nao.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nao.Location = new System.Drawing.Point(177, 222);
            this.nao.Name = "nao";
            this.nao.Size = new System.Drawing.Size(145, 55);
            this.nao.TabIndex = 1;
            this.nao.Text = "Não";
            this.nao.UseVisualStyleBackColor = true;
            this.nao.Click += new System.EventHandler(this.nao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Você tem Plano de Saúde?";
            // 
            // PlanoSaude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nao);
            this.Controls.Add(this.sim);
            this.Name = "PlanoSaude";
            this.Text = "PlanoSaude";
            this.Load += new System.EventHandler(this.PlanoSaude_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sim;
        private System.Windows.Forms.Button nao;
        private System.Windows.Forms.TextBox textBox1;
    }
}