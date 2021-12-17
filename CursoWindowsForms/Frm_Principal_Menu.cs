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
    public partial class Frm_Principal_Menu : Form
    {
        public Frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
                f.ShowDialog();
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void helloWorldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frm_HelloWorld f = new frm_HelloWorld();
                f.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mascaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Mascara f = new Frm_Mascara();
                f.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ValidaCPF f = new Frm_ValidaCPF();
                f.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
                f.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void valídaSenhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ValidaSenha f = new Frm_ValidaSenha();
                f.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
