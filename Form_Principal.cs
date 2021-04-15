using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifraDeCesar
{
    public partial class Form_Principal : Form
    {
        public int passo = 3;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void btn_cripto_Click(object sender, EventArgs e)
        {
            box_cript.Text = string.Empty;
            string texto = (box_texto_original.Text).ToLower();
            string textoFinal = "";

            for(int i = 0; i < texto.Length; i++)
            {
                int letra = (int)texto[i];
                if (letra < 97)
                {
                    letra = 32;
                }
                if(letra >= 97 && letra <= 119)
                {
                    letra = letra + passo;
                } 
                if(letra > 122)
                {
                    letra = letra - 26;
                }                
                textoFinal += Char.ConvertFromUtf32(letra);
                box_cript.Text = textoFinal.ToUpper();
            }
        }

        private void btn_decripto_Click(object sender, EventArgs e)
        {
            box_decript.Text = string.Empty;
            string texto = (box_cript.Text).ToLower();
            string textoFinal = "";

            for (int i = 0; i < texto.Length; i++)
            {
                int letra = (int)texto[i];
                if (letra < 97)
                {
                    letra = 32;
                }
                if (letra >= 100 && letra <= 122)
                {
                    letra = letra - passo;
                }
                textoFinal += Char.ConvertFromUtf32(letra);
                box_decript.Text = textoFinal.ToUpper();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
