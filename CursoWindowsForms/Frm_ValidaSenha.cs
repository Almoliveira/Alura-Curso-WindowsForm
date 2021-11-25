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
                ChecaForcaSenha verifica = new ChecaForcaSenha();
                ChecaForcaSenha.ForcaDaSenha forca;
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


    public class ChecaForcaSenha
    {

        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }


        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }
    }

}
