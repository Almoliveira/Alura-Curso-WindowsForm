using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        bool VerSenhaTxt = false;

        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Senha.Text = string.Empty;
                lbl_Resultado.Text = string.Empty;
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
                Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
                forca = verifica.GetForcaDaSenha(txt_Senha.Text);
                lbl_Resultado.Text = forca.ToString();

                if(lbl_Resultado.Text.Equals("Inaceitavel") || lbl_Resultado.Text.Equals("Fraca")){
                    lbl_Resultado.ForeColor = Color.Red;
                } else if (lbl_Resultado.Text.Equals("Aceitavel"))
                {
                    lbl_Resultado.ForeColor = Color.Blue;
                } else
                {
                    lbl_Resultado.ForeColor = Color.Green;
                }

            }
            catch (Exception er )
            {

                throw er;
            }
        }

        private void btn_VerSenha_Click(object sender, EventArgs e)
        {
            try
            {
                //caractere vazio
                if (VerSenhaTxt)
                {
                    txt_Senha.PasswordChar = '*';
                    btn_VerSenha.Text = "Ver Senha";
                    VerSenhaTxt = false;
                } else
                {
                    txt_Senha.PasswordChar = '\0';
                    btn_VerSenha.Text = "Ocultar Senha";
                    VerSenhaTxt = true;
                }
                

            }
            catch (Exception er)
            {

                throw;
            }
        }
    }

}
