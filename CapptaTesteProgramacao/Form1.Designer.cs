namespace CapptaTesteProgramacao
{
    partial class painelForm
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
            this.posicaoInicialLabel = new System.Windows.Forms.Label();
            this.nomeDaSondaLabel = new System.Windows.Forms.Label();
            this.areaDeExploracaoLabel = new System.Windows.Forms.Label();
            this.posicaoInicialXTextBox = new System.Windows.Forms.TextBox();
            this.nomeDaSondaTextBox = new System.Windows.Forms.TextBox();
            this.areaDeExploracaoXTextBox = new System.Windows.Forms.TextBox();
            this.AdicionarSondaButton = new System.Windows.Forms.Button();
            this.iniciarExpedicaoButton = new System.Windows.Forms.Button();
            this.saidaLabel = new System.Windows.Forms.Label();
            this.instrucoesTextBox = new System.Windows.Forms.TextBox();
            this.instrucoesLabel = new System.Windows.Forms.Label();
            this.enviarButton = new System.Windows.Forms.Button();
            this.posiçaoInicialYTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.direcaoLabel = new System.Windows.Forms.Label();
            this.direcaoComboBox = new System.Windows.Forms.ComboBox();
            this.areaDeExploracaoYTextBox = new System.Windows.Forms.TextBox();
            this.xLabel2 = new System.Windows.Forms.Label();
            this.yLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // posicaoInicialLabel
            // 
            this.posicaoInicialLabel.AutoSize = true;
            this.posicaoInicialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicaoInicialLabel.Location = new System.Drawing.Point(35, 38);
            this.posicaoInicialLabel.Name = "posicaoInicialLabel";
            this.posicaoInicialLabel.Size = new System.Drawing.Size(94, 13);
            this.posicaoInicialLabel.TabIndex = 0;
            this.posicaoInicialLabel.Text = "Posiçao Inicial:";
            // 
            // nomeDaSondaLabel
            // 
            this.nomeDaSondaLabel.AutoSize = true;
            this.nomeDaSondaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDaSondaLabel.Location = new System.Drawing.Point(35, 75);
            this.nomeDaSondaLabel.Name = "nomeDaSondaLabel";
            this.nomeDaSondaLabel.Size = new System.Drawing.Size(101, 13);
            this.nomeDaSondaLabel.TabIndex = 2;
            this.nomeDaSondaLabel.Text = "Nome da Sonda:";
            // 
            // areaDeExploracaoLabel
            // 
            this.areaDeExploracaoLabel.AutoSize = true;
            this.areaDeExploracaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaDeExploracaoLabel.Location = new System.Drawing.Point(15, 138);
            this.areaDeExploracaoLabel.Name = "areaDeExploracaoLabel";
            this.areaDeExploracaoLabel.Size = new System.Drawing.Size(121, 13);
            this.areaDeExploracaoLabel.TabIndex = 5;
            this.areaDeExploracaoLabel.Text = "Área de exploração:";
            // 
            // posicaoInicialXTextBox
            // 
            this.posicaoInicialXTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.posicaoInicialXTextBox.Location = new System.Drawing.Point(135, 35);
            this.posicaoInicialXTextBox.MaxLength = 3;
            this.posicaoInicialXTextBox.Name = "posicaoInicialXTextBox";
            this.posicaoInicialXTextBox.Size = new System.Drawing.Size(28, 20);
            this.posicaoInicialXTextBox.TabIndex = 1;
            this.posicaoInicialXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.posicaoInicialXTextBox_KeyPress);
            // 
            // nomeDaSondaTextBox
            // 
            this.nomeDaSondaTextBox.Location = new System.Drawing.Point(135, 72);
            this.nomeDaSondaTextBox.Name = "nomeDaSondaTextBox";
            this.nomeDaSondaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeDaSondaTextBox.TabIndex = 3;
            // 
            // areaDeExploracaoXTextBox
            // 
            this.areaDeExploracaoXTextBox.Location = new System.Drawing.Point(135, 135);
            this.areaDeExploracaoXTextBox.MaxLength = 3;
            this.areaDeExploracaoXTextBox.Name = "areaDeExploracaoXTextBox";
            this.areaDeExploracaoXTextBox.Size = new System.Drawing.Size(49, 20);
            this.areaDeExploracaoXTextBox.TabIndex = 6;
            this.areaDeExploracaoXTextBox.TextChanged += new System.EventHandler(this.areaDeExploracaoTextBox_TextChanged);
            this.areaDeExploracaoXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaDeExploracaoTextBox_KeyPress);
            // 
            // AdicionarSondaButton
            // 
            this.AdicionarSondaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarSondaButton.Location = new System.Drawing.Point(266, 35);
            this.AdicionarSondaButton.Name = "AdicionarSondaButton";
            this.AdicionarSondaButton.Size = new System.Drawing.Size(75, 57);
            this.AdicionarSondaButton.TabIndex = 4;
            this.AdicionarSondaButton.Text = "Adicionar Sonda";
            this.AdicionarSondaButton.UseCompatibleTextRendering = true;
            this.AdicionarSondaButton.UseVisualStyleBackColor = true;
            this.AdicionarSondaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // iniciarExpedicaoButton
            // 
            this.iniciarExpedicaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarExpedicaoButton.Location = new System.Drawing.Point(76, 179);
            this.iniciarExpedicaoButton.Name = "iniciarExpedicaoButton";
            this.iniciarExpedicaoButton.Size = new System.Drawing.Size(209, 28);
            this.iniciarExpedicaoButton.TabIndex = 7;
            this.iniciarExpedicaoButton.Text = "Iniciar expedição";
            this.iniciarExpedicaoButton.UseCompatibleTextRendering = true;
            this.iniciarExpedicaoButton.UseVisualStyleBackColor = true;
            // 
            // saidaLabel
            // 
            this.saidaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saidaLabel.Location = new System.Drawing.Point(12, 311);
            this.saidaLabel.Name = "saidaLabel";
            this.saidaLabel.Size = new System.Drawing.Size(347, 124);
            this.saidaLabel.TabIndex = 11;
            // 
            // instrucoesTextBox
            // 
            this.instrucoesTextBox.Location = new System.Drawing.Point(12, 280);
            this.instrucoesTextBox.Name = "instrucoesTextBox";
            this.instrucoesTextBox.Size = new System.Drawing.Size(266, 20);
            this.instrucoesTextBox.TabIndex = 9;
            // 
            // instrucoesLabel
            // 
            this.instrucoesLabel.AutoSize = true;
            this.instrucoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucoesLabel.Location = new System.Drawing.Point(15, 264);
            this.instrucoesLabel.Name = "instrucoesLabel";
            this.instrucoesLabel.Size = new System.Drawing.Size(70, 13);
            this.instrucoesLabel.TabIndex = 8;
            this.instrucoesLabel.Text = "Instruções:";
            // 
            // enviarButton
            // 
            this.enviarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarButton.Location = new System.Drawing.Point(284, 277);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(75, 23);
            this.enviarButton.TabIndex = 10;
            this.enviarButton.Text = "Enviar";
            this.enviarButton.UseVisualStyleBackColor = true;
            // 
            // posiçaoInicialYTextBox
            // 
            this.posiçaoInicialYTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.posiçaoInicialYTextBox.Location = new System.Drawing.Point(169, 35);
            this.posiçaoInicialYTextBox.MaxLength = 3;
            this.posiçaoInicialYTextBox.Name = "posiçaoInicialYTextBox";
            this.posiçaoInicialYTextBox.Size = new System.Drawing.Size(28, 20);
            this.posiçaoInicialYTextBox.TabIndex = 12;
            this.posiçaoInicialYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.posiçaoInicialYTextBox_KeyPress);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(139, 20);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(170, 19);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 15;
            this.yLabel.Text = "Y";
            // 
            // direcaoLabel
            // 
            this.direcaoLabel.AutoSize = true;
            this.direcaoLabel.Location = new System.Drawing.Point(201, 19);
            this.direcaoLabel.Name = "direcaoLabel";
            this.direcaoLabel.Size = new System.Drawing.Size(47, 13);
            this.direcaoLabel.TabIndex = 16;
            this.direcaoLabel.Text = "Direção:";
            // 
            // direcaoComboBox
            // 
            this.direcaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direcaoComboBox.FormattingEnabled = true;
            this.direcaoComboBox.Items.AddRange(new object[] {
            "N ",
            "W",
            "S ",
            "E"});
            this.direcaoComboBox.Location = new System.Drawing.Point(203, 34);
            this.direcaoComboBox.MaxLength = 1;
            this.direcaoComboBox.Name = "direcaoComboBox";
            this.direcaoComboBox.Size = new System.Drawing.Size(41, 21);
            this.direcaoComboBox.TabIndex = 17;
            // 
            // areaDeExploracaoYTextBox
            // 
            this.areaDeExploracaoYTextBox.Location = new System.Drawing.Point(195, 135);
            this.areaDeExploracaoYTextBox.MaxLength = 3;
            this.areaDeExploracaoYTextBox.Name = "areaDeExploracaoYTextBox";
            this.areaDeExploracaoYTextBox.Size = new System.Drawing.Size(49, 20);
            this.areaDeExploracaoYTextBox.TabIndex = 18;
            this.areaDeExploracaoYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaDeExploracaoYTextBox_KeyPress);
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.Location = new System.Drawing.Point(139, 119);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(14, 13);
            this.xLabel2.TabIndex = 19;
            this.xLabel2.Text = "X";
            // 
            // yLabel2
            // 
            this.yLabel2.AutoSize = true;
            this.yLabel2.Location = new System.Drawing.Point(200, 119);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(14, 13);
            this.yLabel2.TabIndex = 20;
            this.yLabel2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "____________________________________________________________";
            // 
            // painelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yLabel2);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.areaDeExploracaoYTextBox);
            this.Controls.Add(this.direcaoComboBox);
            this.Controls.Add(this.direcaoLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.posiçaoInicialYTextBox);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.instrucoesLabel);
            this.Controls.Add(this.instrucoesTextBox);
            this.Controls.Add(this.saidaLabel);
            this.Controls.Add(this.iniciarExpedicaoButton);
            this.Controls.Add(this.AdicionarSondaButton);
            this.Controls.Add(this.areaDeExploracaoXTextBox);
            this.Controls.Add(this.nomeDaSondaTextBox);
            this.Controls.Add(this.posicaoInicialXTextBox);
            this.Controls.Add(this.areaDeExploracaoLabel);
            this.Controls.Add(this.nomeDaSondaLabel);
            this.Controls.Add(this.posicaoInicialLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "painelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de controle";
            this.Load += new System.EventHandler(this.painelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label posicaoInicialLabel;
        private System.Windows.Forms.Label nomeDaSondaLabel;
        private System.Windows.Forms.Label areaDeExploracaoLabel;
        private System.Windows.Forms.TextBox posicaoInicialXTextBox;
        private System.Windows.Forms.TextBox nomeDaSondaTextBox;
        private System.Windows.Forms.TextBox areaDeExploracaoXTextBox;
        private System.Windows.Forms.Button AdicionarSondaButton;
        private System.Windows.Forms.Button iniciarExpedicaoButton;
        private System.Windows.Forms.Label saidaLabel;
        private System.Windows.Forms.TextBox instrucoesTextBox;
        private System.Windows.Forms.Label instrucoesLabel;
        private System.Windows.Forms.Button enviarButton;
        private System.Windows.Forms.TextBox posiçaoInicialYTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label direcaoLabel;
        private System.Windows.Forms.ComboBox direcaoComboBox;
        private System.Windows.Forms.TextBox areaDeExploracaoYTextBox;
        private System.Windows.Forms.Label xLabel2;
        private System.Windows.Forms.Label yLabel2;
        private System.Windows.Forms.Label label1;
    }
}

