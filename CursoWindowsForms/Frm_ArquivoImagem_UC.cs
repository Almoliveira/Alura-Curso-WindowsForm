using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog Cdb = new ColorDialog();
                if(Cdb.ShowDialog() == DialogResult.OK)
                {
                    Lbl_ArquivoImagem.ForeColor = Cdb.Color;
                }
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog Fdg = new FontDialog();

                if(Fdg.ShowDialog() == DialogResult.OK)
                {
                    Lbl_ArquivoImagem.Font = Fdg.Font;
                }
            }
            catch (Exception er)
            {

                throw er;
            }
        }
    }
}
