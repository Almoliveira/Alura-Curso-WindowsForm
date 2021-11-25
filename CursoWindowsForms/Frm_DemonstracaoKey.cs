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
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txt_Msg.AppendText("\r\n" + "Pressionei uma tecla" + e.KeyCode + "\r\n");
                txt_Msg.AppendText("\t" + "Código da tecla: " + (int)e.KeyCode + "\r\n");
                txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

                lbl_Lower.Text = e.KeyCode.ToString().ToLower();
                lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Msg.Text = string.Empty;
                txt_Input .Text = string.Empty;
                lbl_Upper.Text = string.Empty;
                lbl_Lower.Text = string.Empty;
            }
            catch (Exception er)
            {

                throw er;
            }
        }
    }
}
