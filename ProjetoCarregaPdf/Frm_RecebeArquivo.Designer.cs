namespace ProjetoCarregaPdf
{
    partial class Frm_RecebeArquivo
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
            button1 = new Button();
            tbl = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tbl.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbl
            // 
            tbl.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tbl.ColumnCount = 2;
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbl.Controls.Add(label1, 0, 0);
            tbl.Controls.Add(label2, 1, 0);
            tbl.Location = new Point(9, 22);
            tbl.Name = "tbl";
            tbl.RowCount = 1;
            tbl.RowStyles.Add(new RowStyle());
            tbl.Size = new Size(779, 50);
            tbl.TabIndex = 1;
            tbl.TabStop = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 1);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // Frm_RecebeArquivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbl);
            Controls.Add(button1);
            Name = "Frm_RecebeArquivo";
            Text = "Lista arquivos";
            tbl.ResumeLayout(false);
            tbl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tbl;
    }
}