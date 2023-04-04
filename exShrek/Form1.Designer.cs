namespace exShrek
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorBase = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.chkAgravamento = new System.Windows.Forms.CheckBox();
            this.chkDescontoSocio = new System.Windows.Forms.CheckBox();
            this.chkDescontoEscalao = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxConcelho = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DO VALOR DA AVENÇA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANO DE NASCIMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR BASE";
            // 
            // txtValorBase
            // 
            this.txtValorBase.Location = new System.Drawing.Point(251, 194);
            this.txtValorBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorBase.Name = "txtValorBase";
            this.txtValorBase.Size = new System.Drawing.Size(132, 22);
            this.txtValorBase.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(251, 100);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(251, 149);
            this.txtAnoNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(132, 22);
            this.txtAnoNascimento.TabIndex = 6;
            // 
            // chkAgravamento
            // 
            this.chkAgravamento.AutoSize = true;
            this.chkAgravamento.Location = new System.Drawing.Point(135, 326);
            this.chkAgravamento.Margin = new System.Windows.Forms.Padding(4);
            this.chkAgravamento.Name = "chkAgravamento";
            this.chkAgravamento.Size = new System.Drawing.Size(241, 20);
            this.chkAgravamento.TabIndex = 7;
            this.chkAgravamento.Text = "TEM AGRAVAMENTO? 12 EUROS";
            this.chkAgravamento.UseVisualStyleBackColor = true;
            // 
            // chkDescontoSocio
            // 
            this.chkDescontoSocio.AutoSize = true;
            this.chkDescontoSocio.Location = new System.Drawing.Point(135, 298);
            this.chkDescontoSocio.Margin = new System.Windows.Forms.Padding(4);
            this.chkDescontoSocio.Name = "chkDescontoSocio";
            this.chkDescontoSocio.Size = new System.Drawing.Size(200, 20);
            this.chkDescontoSocio.TabIndex = 8;
            this.chkDescontoSocio.Text = "DESCONTO DE SOCIO? 5%";
            this.chkDescontoSocio.UseVisualStyleBackColor = true;
            // 
            // chkDescontoEscalao
            // 
            this.chkDescontoEscalao.AutoSize = true;
            this.chkDescontoEscalao.Location = new System.Drawing.Point(135, 270);
            this.chkDescontoEscalao.Margin = new System.Windows.Forms.Padding(4);
            this.chkDescontoEscalao.Name = "chkDescontoEscalao";
            this.chkDescontoEscalao.Size = new System.Drawing.Size(228, 20);
            this.chkDescontoEscalao.TabIndex = 9;
            this.chkDescontoEscalao.Text = "DESCONTO DE ESCALAO? 10%";
            this.chkDescontoEscalao.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "RESIDE NO DISTRITO?";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(251, 399);
            this.rdbSim.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(51, 20);
            this.rdbSim.TabIndex = 12;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "SIM";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(326, 400);
            this.rdbNao.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(57, 20);
            this.rdbNao.TabIndex = 13;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "NAO";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "CONCELHO";
            // 
            // cbxConcelho
            // 
            this.cbxConcelho.FormattingEnabled = true;
            this.cbxConcelho.Items.AddRange(new object[] {
            "Amares",
            "Famalicão"});
            this.cbxConcelho.Location = new System.Drawing.Point(524, 399);
            this.cbxConcelho.Margin = new System.Windows.Forms.Padding(4);
            this.cbxConcelho.Name = "cbxConcelho";
            this.cbxConcelho.Size = new System.Drawing.Size(160, 24);
            this.cbxConcelho.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(700, 399);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCalcular
            // 
            this.txtCalcular.Location = new System.Drawing.Point(808, 401);
            this.txtCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(132, 22);
            this.txtCalcular.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxConcelho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkDescontoEscalao);
            this.Controls.Add(this.chkDescontoSocio);
            this.Controls.Add(this.chkAgravamento);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValorBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorBase;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.CheckBox chkAgravamento;
        private System.Windows.Forms.CheckBox chkDescontoSocio;
        private System.Windows.Forms.CheckBox chkDescontoEscalao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxConcelho;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCalcular;
    }
}

