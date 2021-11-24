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
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Titulo.Text = txt_conteudoLabel.Text;
            }
            catch (Exception er)
            {

                throw er;
            }
        }
    }
}
