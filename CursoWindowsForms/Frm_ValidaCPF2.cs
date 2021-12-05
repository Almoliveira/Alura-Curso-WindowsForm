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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                msk_CPF.Text = string.Empty;
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {

            string vConteudo;
            vConteudo = msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();
            if(vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } 
            else
            {
                if(vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 digitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Você Deseja Realmente validar o CPF?",
                                   "Mensagem de Validação",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            bool validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
                            if (validaCPF)
                            {


                                MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        catch (Exception er)
                        {

                            throw er;
                        }
                    }
                }


               
            }


            
        }
    }
}
