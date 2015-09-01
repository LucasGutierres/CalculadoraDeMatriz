using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CalculadoraDeMatriz
{
    public partial class Form1 : Form
    { 
        public int linha;
        public int coluna;
        private TextBox[,] Matrix;
        public Form1()
        {
           
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                linha = Convert.ToInt16(matriz1_Linha.Text);
                coluna = Convert.ToInt16(matriz1_Coluna.Text);
                if (Matrix != null)
                {
                    for (int i = 0; i < Matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix.GetLength(1); j++)
                        {
                            if (Matrix[i, j] != null)
                                this.Controls.Remove(Matrix[i, j]);
                        }
                    }
                }
                Matrix = new TextBox[linha, coluna];
                Criador();
        }
        void Criador() {
            for (int i = 0; i < Matrix.GetLength(0); i++ ) {
                for (int j = 0; j < Matrix.GetLength(1); j++) {
                Matrix[i,j] = new TextBox();
                Matrix[i,j].Text = "0";
                Matrix[i, j].Top = (i * Matrix[i,j].Height) + 60;
                Matrix[i, j].Left = (j * 35) + 10;
                Matrix[i, j].Width = 30;
                this.Controls.Add(Matrix[i, j]);
                }
            }

        }

   
    }
}
