namespace ProjetoCarregaPdf
{
    partial class Frm_EnviaArquivo
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
            Lbl_NomeEnvia = new Label();
            Txt_Nome = new TextBox();
            Txt_Assunto = new TextBox();
            Lbl_Assunto = new Label();
            Lbl_Time = new Label();
            Btn_arquivo = new Button();
            Lbl_ArquivoSelecionado = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Lbl_NomeEnvia
            // 
            Lbl_NomeEnvia.AutoSize = true;
            Lbl_NomeEnvia.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NomeEnvia.Location = new Point(12, 16);
            Lbl_NomeEnvia.Name = "Lbl_NomeEnvia";
            Lbl_NomeEnvia.Size = new Size(59, 19);
            Lbl_NomeEnvia.TabIndex = 0;
            Lbl_NomeEnvia.Text = "Nome ";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(12, 38);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(404, 27);
            Txt_Nome.TabIndex = 1;
            // 
            // Txt_Assunto
            // 
            Txt_Assunto.Location = new Point(12, 114);
            Txt_Assunto.Name = "Txt_Assunto";
            Txt_Assunto.Size = new Size(404, 27);
            Txt_Assunto.TabIndex = 3;
            // 
            // Lbl_Assunto
            // 
            Lbl_Assunto.AutoSize = true;
            Lbl_Assunto.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Assunto.Location = new Point(12, 92);
            Lbl_Assunto.Name = "Lbl_Assunto";
            Lbl_Assunto.Size = new Size(74, 19);
            Lbl_Assunto.TabIndex = 2;
            Lbl_Assunto.Text = "Assunto";
            // 
            // Lbl_Time
            // 
            Lbl_Time.AutoSize = true;
            Lbl_Time.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Time.Location = new Point(130, 487);
            Lbl_Time.Name = "Lbl_Time";
            Lbl_Time.Size = new Size(0, 20);
            Lbl_Time.TabIndex = 4;
            // 
            // Btn_arquivo
            // 
            Btn_arquivo.AutoEllipsis = true;
            Btn_arquivo.BackColor = Color.ForestGreen;
            Btn_arquivo.Cursor = Cursors.Hand;
            Btn_arquivo.ForeColor = SystemColors.ButtonHighlight;
            Btn_arquivo.Location = new Point(12, 200);
            Btn_arquivo.Name = "Btn_arquivo";
            Btn_arquivo.Size = new Size(404, 28);
            Btn_arquivo.TabIndex = 5;
            Btn_arquivo.Text = "Selecionar Arquivo";
            Btn_arquivo.UseVisualStyleBackColor = false;
            Btn_arquivo.Click += Btn_arquivo_Click;
            // 
            // Lbl_ArquivoSelecionado
            // 
            Lbl_ArquivoSelecionado.AutoSize = true;
            Lbl_ArquivoSelecionado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_ArquivoSelecionado.Location = new Point(12, 242);
            Lbl_ArquivoSelecionado.Name = "Lbl_ArquivoSelecionado";
            Lbl_ArquivoSelecionado.Size = new Size(0, 20);
            Lbl_ArquivoSelecionado.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 521);
            button1.Name = "button1";
            button1.Size = new Size(404, 29);
            button1.TabIndex = 7;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 361);
            button2.Name = "button2";
            button2.Size = new Size(404, 29);
            button2.TabIndex = 8;
            button2.Text = "Enviar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Frm_EnviaArquivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGreen;
            ClientSize = new Size(428, 562);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Lbl_ArquivoSelecionado);
            Controls.Add(Btn_arquivo);
            Controls.Add(Lbl_Time);
            Controls.Add(Txt_Assunto);
            Controls.Add(Lbl_Assunto);
            Controls.Add(Txt_Nome);
            Controls.Add(Lbl_NomeEnvia);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_EnviaArquivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envia Arquivo";
            Load += Frm_EnviaArquivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_NomeEnvia;
        private TextBox Txt_Nome;
        private TextBox Txt_Assunto;
        private Label Lbl_Assunto;
        private Label Lbl_Time;
        private Button Btn_arquivo;
        private Label Lbl_ArquivoSelecionado;
        private Button button1;
        private Button button2;
    }
}