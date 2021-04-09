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
        public Form_Principal()
        {
            InitializeComponent();
            box_passo.Text = "3";
        }

        private void btn_cripto_Click(object sender, EventArgs e)
        {
            box_cript.Text = string.Empty;
            int passo = Convert.ToInt32(box_passo.Text);
            for(int i = 0; i < box_texto_original.Text.Length; i++)
            {
                int ASCII = (int)box_texto_original.Text[i];
                int ASCIIC = ASCII + passo;
                box_cript.Text += Char.ConvertFromUtf32(ASCIIC);
            }
        }

        private void btn_decripto_Click(object sender, EventArgs e)
        {
            box_decript.Text = string.Empty;
            int passo = Convert.ToInt32(box_passo.Text);
            for (int i = 0; i < box_cript.Text.Length; i++)
            {
                int ASCII = (int)box_cript.Text[i];
                int ASCIIC = ASCII - passo;
                box_decript.Text += Char.ConvertFromUtf32(ASCIIC);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
