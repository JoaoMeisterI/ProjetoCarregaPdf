using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCarregaPdf
{
    public partial class Frm_EnviaArquivo : Form
    {


        Frm_RecebeArquivo Fr = new Frm_RecebeArquivo();
        public Frm_EnviaArquivo()
        {
            InitializeComponent();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_EnviaArquivo_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Time_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Btn_arquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Op = new OpenFileDialog();
            Op.Title = "Selecione Seu Arquivo";
            Op.Filter = "PDF|*.pdf";


            if (Op.ShowDialog() == DialogResult.OK)
            {
                List<string> listaOp = Op.FileName.Split('\\').ToList();
                Lbl_ArquivoSelecionado.Text = $"Selecionado o arquivo: {listaOp[listaOp.Count - 1]}";
                DateTime agora = DateTime.Now;
                string agora2 = agora.ToString();
                Lbl_Time.Text = agora2;

            }
            else
            {
                Lbl_ArquivoSelecionado.Text = "Nenhum arquivo selecionado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["nome"] = Txt_Nome.Text;
            dic["assunto"] = Txt_Assunto.Text;

            Fr.ListaNomes.Add(dic);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fr.ShowDialog();
        }
    }
}
