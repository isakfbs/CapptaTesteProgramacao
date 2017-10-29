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
            this.saidaLabel3 = new System.Windows.Forms.Label();
            this.instrucoesTextBox = new System.Windows.Forms.TextBox();
            this.instrucoesLabel = new System.Windows.Forms.Label();
            this.enviarButton = new System.Windows.Forms.Button();
            this.posicaoInicialYTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.direcaoLabel = new System.Windows.Forms.Label();
            this.direcaoComboBox = new System.Windows.Forms.ComboBox();
            this.areaDeExploracaoYTextBox = new System.Windows.Forms.TextBox();
            this.xLabel2 = new System.Windows.Forms.Label();
            this.yLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saidaLabel2 = new System.Windows.Forms.Label();
            this.saidaLabel1 = new System.Windows.Forms.Label();
            this.areaDeExploraçãoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // posicaoInicialLabel
            // 
            this.posicaoInicialLabel.AutoSize = true;
            this.posicaoInicialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicaoInicialLabel.Location = new System.Drawing.Point(28, 87);
            this.posicaoInicialLabel.Name = "posicaoInicialLabel";
            this.posicaoInicialLabel.Size = new System.Drawing.Size(94, 13);
            this.posicaoInicialLabel.TabIndex = 9;
            this.posicaoInicialLabel.Text = "Posiçao Inicial:";
            // 
            // nomeDaSondaLabel
            // 
            this.nomeDaSondaLabel.AutoSize = true;
            this.nomeDaSondaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDaSondaLabel.Location = new System.Drawing.Point(26, 123);
            this.nomeDaSondaLabel.Name = "nomeDaSondaLabel";
            this.nomeDaSondaLabel.Size = new System.Drawing.Size(101, 13);
            this.nomeDaSondaLabel.TabIndex = 14;
            this.nomeDaSondaLabel.Text = "Nome da Sonda:";
            // 
            // areaDeExploracaoLabel
            // 
            this.areaDeExploracaoLabel.AutoSize = true;
            this.areaDeExploracaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaDeExploracaoLabel.Location = new System.Drawing.Point(8, 32);
            this.areaDeExploracaoLabel.Name = "areaDeExploracaoLabel";
            this.areaDeExploracaoLabel.Size = new System.Drawing.Size(121, 13);
            this.areaDeExploracaoLabel.TabIndex = 2;
            this.areaDeExploracaoLabel.Text = "Área de exploração:";
            // 
            // posicaoInicialXTextBox
            // 
            this.posicaoInicialXTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.posicaoInicialXTextBox.Location = new System.Drawing.Point(128, 85);
            this.posicaoInicialXTextBox.MaxLength = 3;
            this.posicaoInicialXTextBox.Name = "posicaoInicialXTextBox";
            this.posicaoInicialXTextBox.Size = new System.Drawing.Size(28, 20);
            this.posicaoInicialXTextBox.TabIndex = 10;
            this.posicaoInicialXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.posicaoInicialXTextBox_KeyPress);
            // 
            // nomeDaSondaTextBox
            // 
            this.nomeDaSondaTextBox.Location = new System.Drawing.Point(128, 120);
            this.nomeDaSondaTextBox.Name = "nomeDaSondaTextBox";
            this.nomeDaSondaTextBox.Size = new System.Drawing.Size(107, 20);
            this.nomeDaSondaTextBox.TabIndex = 15;
            // 
            // areaDeExploracaoXTextBox
            // 
            this.areaDeExploracaoXTextBox.Location = new System.Drawing.Point(128, 29);
            this.areaDeExploracaoXTextBox.MaxLength = 3;
            this.areaDeExploracaoXTextBox.Name = "areaDeExploracaoXTextBox";
            this.areaDeExploracaoXTextBox.Size = new System.Drawing.Size(28, 20);
            this.areaDeExploracaoXTextBox.TabIndex = 3;
            this.areaDeExploracaoXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaDeExploracaoTextBox_KeyPress);
            // 
            // AdicionarSondaButton
            // 
            this.AdicionarSondaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarSondaButton.Location = new System.Drawing.Point(259, 84);
            this.AdicionarSondaButton.Name = "AdicionarSondaButton";
            this.AdicionarSondaButton.Size = new System.Drawing.Size(75, 57);
            this.AdicionarSondaButton.TabIndex = 13;
            this.AdicionarSondaButton.Text = "Adicionar Sonda";
            this.AdicionarSondaButton.UseCompatibleTextRendering = true;
            this.AdicionarSondaButton.UseVisualStyleBackColor = true;
            this.AdicionarSondaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // iniciarExpedicaoButton
            // 
            this.iniciarExpedicaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarExpedicaoButton.Location = new System.Drawing.Point(78, 213);
            this.iniciarExpedicaoButton.Name = "iniciarExpedicaoButton";
            this.iniciarExpedicaoButton.Size = new System.Drawing.Size(209, 28);
            this.iniciarExpedicaoButton.TabIndex = 18;
            this.iniciarExpedicaoButton.Text = "Iniciar expedição";
            this.iniciarExpedicaoButton.UseCompatibleTextRendering = true;
            this.iniciarExpedicaoButton.UseVisualStyleBackColor = true;
            this.iniciarExpedicaoButton.Click += new System.EventHandler(this.iniciarExpedicaoButton_Click);
            // 
            // saidaLabel3
            // 
            this.saidaLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saidaLabel3.Location = new System.Drawing.Point(12, 389);
            this.saidaLabel3.Name = "saidaLabel3";
            this.saidaLabel3.Size = new System.Drawing.Size(347, 124);
            this.saidaLabel3.TabIndex = 23;
            // 
            // instrucoesTextBox
            // 
            this.instrucoesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.instrucoesTextBox.Location = new System.Drawing.Point(12, 342);
            this.instrucoesTextBox.Name = "instrucoesTextBox";
            this.instrucoesTextBox.Size = new System.Drawing.Size(266, 20);
            this.instrucoesTextBox.TabIndex = 21;
            this.instrucoesTextBox.TextChanged += new System.EventHandler(this.instrucoesTextBox_TextChanged);
            this.instrucoesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.instrucoesTextBox_KeyPress);
            // 
            // instrucoesLabel
            // 
            this.instrucoesLabel.AutoSize = true;
            this.instrucoesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucoesLabel.Location = new System.Drawing.Point(15, 324);
            this.instrucoesLabel.Name = "instrucoesLabel";
            this.instrucoesLabel.Size = new System.Drawing.Size(70, 13);
            this.instrucoesLabel.TabIndex = 20;
            this.instrucoesLabel.Text = "Instruções:";
            // 
            // enviarButton
            // 
            this.enviarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarButton.Location = new System.Drawing.Point(284, 339);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(75, 23);
            this.enviarButton.TabIndex = 22;
            this.enviarButton.Text = "Enviar";
            this.enviarButton.UseVisualStyleBackColor = true;
            this.enviarButton.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // posicaoInicialYTextBox
            // 
            this.posicaoInicialYTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.posicaoInicialYTextBox.Location = new System.Drawing.Point(160, 85);
            this.posicaoInicialYTextBox.MaxLength = 3;
            this.posicaoInicialYTextBox.Name = "posicaoInicialYTextBox";
            this.posicaoInicialYTextBox.Size = new System.Drawing.Size(28, 20);
            this.posicaoInicialYTextBox.TabIndex = 11;
            this.posicaoInicialYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.posiçaoInicialYTextBox_KeyPress);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(132, 70);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(163, 69);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 7;
            this.yLabel.Text = "Y";
            // 
            // direcaoLabel
            // 
            this.direcaoLabel.AutoSize = true;
            this.direcaoLabel.Location = new System.Drawing.Point(194, 69);
            this.direcaoLabel.Name = "direcaoLabel";
            this.direcaoLabel.Size = new System.Drawing.Size(47, 13);
            this.direcaoLabel.TabIndex = 8;
            this.direcaoLabel.Text = "Direção:";
            // 
            // direcaoComboBox
            // 
            this.direcaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direcaoComboBox.FormattingEnabled = true;
            this.direcaoComboBox.Items.AddRange(new object[] {
            "E",
            "N",
            "S",
            "W"});
            this.direcaoComboBox.Location = new System.Drawing.Point(194, 84);
            this.direcaoComboBox.MaxLength = 1;
            this.direcaoComboBox.Name = "direcaoComboBox";
            this.direcaoComboBox.Size = new System.Drawing.Size(41, 21);
            this.direcaoComboBox.TabIndex = 12;
            // 
            // areaDeExploracaoYTextBox
            // 
            this.areaDeExploracaoYTextBox.Location = new System.Drawing.Point(160, 29);
            this.areaDeExploracaoYTextBox.MaxLength = 3;
            this.areaDeExploracaoYTextBox.Name = "areaDeExploracaoYTextBox";
            this.areaDeExploracaoYTextBox.Size = new System.Drawing.Size(28, 20);
            this.areaDeExploracaoYTextBox.TabIndex = 4;
            this.areaDeExploracaoYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaDeExploracaoYTextBox_KeyPress);
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.Location = new System.Drawing.Point(131, 16);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(14, 13);
            this.xLabel2.TabIndex = 0;
            this.xLabel2.Text = "X";
            // 
            // yLabel2
            // 
            this.yLabel2.AutoSize = true;
            this.yLabel2.Location = new System.Drawing.Point(163, 16);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(14, 13);
            this.yLabel2.TabIndex = 1;
            this.yLabel2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "____________________________________________________________";
            // 
            // saidaLabel2
            // 
            this.saidaLabel2.Location = new System.Drawing.Point(84, 320);
            this.saidaLabel2.Name = "saidaLabel2";
            this.saidaLabel2.Size = new System.Drawing.Size(194, 20);
            this.saidaLabel2.TabIndex = 19;
            this.saidaLabel2.Text = "L:Esquerda; M: Mover; R:Direita";
            this.saidaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saidaLabel1
            // 
            this.saidaLabel1.Location = new System.Drawing.Point(3, 156);
            this.saidaLabel1.Name = "saidaLabel1";
            this.saidaLabel1.Size = new System.Drawing.Size(364, 34);
            this.saidaLabel1.TabIndex = 16;
            this.saidaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areaDeExploraçãoButton
            // 
            this.areaDeExploraçãoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaDeExploraçãoButton.Location = new System.Drawing.Point(259, 26);
            this.areaDeExploraçãoButton.Name = "areaDeExploraçãoButton";
            this.areaDeExploraçãoButton.Size = new System.Drawing.Size(75, 23);
            this.areaDeExploraçãoButton.TabIndex = 5;
            this.areaDeExploraçãoButton.Text = "Confirmar";
            this.areaDeExploraçãoButton.UseVisualStyleBackColor = true;
            this.areaDeExploraçãoButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // painelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 522);
            this.Controls.Add(this.areaDeExploraçãoButton);
            this.Controls.Add(this.saidaLabel1);
            this.Controls.Add(this.saidaLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yLabel2);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.areaDeExploracaoYTextBox);
            this.Controls.Add(this.direcaoComboBox);
            this.Controls.Add(this.direcaoLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.posicaoInicialYTextBox);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.instrucoesLabel);
            this.Controls.Add(this.instrucoesTextBox);
            this.Controls.Add(this.saidaLabel3);
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
        private System.Windows.Forms.Label saidaLabel3;
        private System.Windows.Forms.TextBox instrucoesTextBox;
        private System.Windows.Forms.Label instrucoesLabel;
        private System.Windows.Forms.Button enviarButton;
        private System.Windows.Forms.TextBox posicaoInicialYTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label direcaoLabel;
        private System.Windows.Forms.ComboBox direcaoComboBox;
        private System.Windows.Forms.TextBox areaDeExploracaoYTextBox;
        private System.Windows.Forms.Label xLabel2;
        private System.Windows.Forms.Label yLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saidaLabel2;
        private System.Windows.Forms.Label saidaLabel1;
        private System.Windows.Forms.Button areaDeExploraçãoButton;
    }
}

