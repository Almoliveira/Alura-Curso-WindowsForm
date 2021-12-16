using CursoWindowsFormsBiblioteca;
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
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }



       
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Resultado.Text = string.Empty;
                msk_CPF.Text = string.Empty;
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            try
            {
                bool validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
                if(validaCPF)
                {
                    lbl_Resultado.Text = "CPF VÁLIDO";
                    lbl_Resultado.ForeColor = Color.Green;
                }
                else
                {
                    lbl_Resultado.Text = "CPF INVÁLIDO";
                    lbl_Resultado.ForeColor = Color.Red;
                }


            }
            catch (Exception er)
            {

                throw er;
            }
        }
    }
}
