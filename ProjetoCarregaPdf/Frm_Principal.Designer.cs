namespace ProjetoCarregaPdf
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            acessosToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            funçõesToolStripMenuItem = new ToolStripMenuItem();
            fiscalToolStripMenuItem = new ToolStripMenuItem();
            geralToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGreen;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.ImeMode = ImeMode.Katakana;
            menuStrip1.Items.AddRange(new ToolStripItem[] { acessosToolStripMenuItem, funçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1196, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // acessosToolStripMenuItem
            // 
            acessosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, sairToolStripMenuItem });
            acessosToolStripMenuItem.Name = "acessosToolStripMenuItem";
            acessosToolStripMenuItem.Size = new Size(75, 24);
            acessosToolStripMenuItem.Text = "Acessos";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(129, 26);
            loginToolStripMenuItem.Text = "Login";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(129, 26);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // funçõesToolStripMenuItem
            // 
            funçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fiscalToolStripMenuItem, geralToolStripMenuItem });
            funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            funçõesToolStripMenuItem.Size = new Size(76, 24);
            funçõesToolStripMenuItem.Text = "Funções";
            // 
            // fiscalToolStripMenuItem
            // 
            fiscalToolStripMenuItem.Name = "fiscalToolStripMenuItem";
            fiscalToolStripMenuItem.Size = new Size(128, 26);
            fiscalToolStripMenuItem.Text = "Fiscal";
            // 
            // geralToolStripMenuItem
            // 
            geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            geralToolStripMenuItem.Size = new Size(128, 26);
            geralToolStripMenuItem.Text = "Geral";
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1196, 711);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem acessosToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem funçõesToolStripMenuItem;
        private ToolStripMenuItem fiscalToolStripMenuItem;
        private ToolStripMenuItem geralToolStripMenuItem;
    }
}
