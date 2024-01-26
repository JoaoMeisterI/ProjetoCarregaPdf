using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCarregaPdf
{
    public partial class Frm_RecebeArquivo : Form
    {
        public List<Dictionary<string, string>> ListaNomes = new List<Dictionary<string, string>>();
        
        public TextBox textBoxNome;
        public TextBox textBoxAssunto;

        public Frm_RecebeArquivo()
        {
            InitializeComponent();


           


        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl.Dock = DockStyle.Fill; // Preencha o formulário com o TableLayoutPanel

            // Adicione a TableLayoutPanel ao formulário
            this.Controls.Add(tbl);

            Label lbl1 = new Label();
            Label lbl2 = new Label();

            foreach (var dict in ListaNomes)
            {
                string nome = dict["nome"];
                string assunto = dict["assunto"];

                lbl1.Text = nome;
                lbl2.Text = assunto;
                AdicionarControle(lbl1, lbl2);
                AdicionarControle(lbl1, lbl2);
            }


           

            // Adicione TextBoxes e Labels iniciais
          

            
        }

        private void AdicionarControle(Label label1, Label label2)
        {
            // Adicione um rótulo
            
          
            label1.AutoSize = true;
            label2.AutoSize = true;

            // Adicione um controle TextBox
            

            // Adicione o rótulo e o controle ao TableLayoutPanel
            tbl.Controls.Add(label1);
            tbl.Controls.Add(label2);

            // Atualize o número de linhas
            tbl.RowCount += 1;
            tbl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }






    }
}

