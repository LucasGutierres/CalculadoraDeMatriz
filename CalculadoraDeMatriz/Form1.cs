using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMatriz
{
    public partial class Form1 : Form
    { 
        public int linha1;
        public int coluna1;
        public int linha2;
        public int coluna2;
        public int colunaResposta;
        public int linhaResposta;
        private int multEscalar;
        private TextBox[,] Matrix1;
        private TextBox[,] Matrix2;
        private TextBox[,] MatrixR;

        public Form1()
        {           
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (matriz1_Linha.SelectedIndex == -1) linha1 = 0; else linha1 = Convert.ToInt32(matriz1_Linha.Text);
            if (matriz1_Coluna.SelectedIndex == -1) coluna1 = 0; else coluna1 = Convert.ToInt32(matriz1_Coluna.Text);
            if (matriz2_Linha.SelectedIndex == -1) linha2 = 0; else linha2 = Convert.ToInt16(matriz2_Linha.Text);
            if (matriz2_Coluna.SelectedIndex == -1) coluna2 = 0; else coluna2 = Convert.ToInt16(matriz2_Coluna.Text);

                TextBoxOverride();
                
                Matrix1 = new TextBox[linha1, coluna1];
                Matrix2 = new TextBox[linha2, coluna2];
                Criar();
        }

        void TextBoxOverride() {
            if (Matrix1 != null)
            {
                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        if (Matrix1[i, j] != null)
                            this.Controls.Remove(Matrix1[i, j]);
                    }
                }
            }
            if (Matrix2 != null)
            {
                for (int i = 0; i < Matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix2.GetLength(1); j++)
                    {
                        if (Matrix2[i, j] != null)
                            this.Controls.Remove(Matrix2[i, j]);
                    }
                }
            }
        }

        void Criar() {

                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        Matrix1[i, j] = new TextBox();
                        Matrix1[i, j].Text = "3";
                        Matrix1[i, j].Top = (i * Matrix1[i, j].Height) + 60;
                        Matrix1[i, j].Left = (j * 35) + 10;
                        Matrix1[i, j].Width = 30;
                        this.Controls.Add(Matrix1[i, j]);
                    }
                }
                 for (int i = 0; i < Matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix2.GetLength(1); j++)
                    {
                        Matrix2[i, j] = new TextBox();
                        Matrix2[i, j].Text = "1";
                        Matrix2[i, j].Top = (i * Matrix2[i, j].Height) + 60;
                        Matrix2[i, j].Left = (j * 35) + 480;
                        Matrix2[i, j].Width = 30;
                        this.Controls.Add(Matrix2[i, j]);
                    }
                }

            }

        private void SumButton_Click(object sender, EventArgs e)
        {
            linhaResposta = linha1;
            colunaResposta = coluna1;

            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            this.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }

            MatrixR = new TextBox[linhaResposta, colunaResposta];

            if(linha1 == linha2 && coluna2 == coluna1){
                for (int i = 0; i < MatrixR.GetLength(0); i++) 
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++) 
                    {
                        MatrixR[i, j] = new TextBox();
                        MatrixR[i, j].Text = Convert.ToString(Convert.ToInt32(Matrix1[i, j].Text) + Convert.ToInt32(Matrix2[i,j].Text));
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 180;
                        MatrixR[i, j].Left = (j * 35) + 245;
                        MatrixR[i, j].Width = 30;
                        this.Controls.Add(MatrixR[i,j]);
                    }

                }
                
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            linhaResposta = linha1;
            colunaResposta = coluna1;

            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            this.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }

            MatrixR = new TextBox[linhaResposta, colunaResposta];

            if (linha1 == linha2 && coluna2 == coluna1)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        MatrixR[i, j] = new TextBox();
                        MatrixR[i, j].Text = Convert.ToString(Convert.ToInt32(Matrix1[i, j].Text) - Convert.ToInt32(Matrix2[i, j].Text));
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 180;
                        MatrixR[i, j].Left = (j * 35) + 245;
                        MatrixR[i, j].Width = 30;
                        this.Controls.Add(MatrixR[i, j]);
                    }
                }
            }
        }

        private void MultEscalar(object sender, EventArgs e)
        {
            multEscalar = Convert.ToInt32(QuoeficienteME.Text);
            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            this.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }
            MatrixR = new TextBox[linha1, coluna1];

            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                {
                    MatrixR[i, j] = new TextBox();
                    MatrixR[i, j].Text = Convert.ToString(Convert.ToInt32(Matrix1[i, j].Text) * multEscalar);
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 180;
                    MatrixR[i, j].Left = (j * 35) + 245;
                    MatrixR[i, j].Width = 30;
                    this.Controls.Add(MatrixR[i, j]);
                }
            }
        }

        private void Simetria(object sender, EventArgs e)
        {
            
            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            this.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }
            
            MatrixR = new TextBox[coluna1,linha1];

            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                {
                    MatrixR[i, j] = new TextBox();
                    MatrixR[i, j].Text = Convert.ToString(Matrix1[j,i].Text);
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 180;
                    MatrixR[i, j].Left = (j * 35) + 245;
                    MatrixR[i, j].Width = 30;
                    this.Controls.Add(MatrixR[i, j]);
                }
            }
        }

        private void Mult(object sender, EventArgs e)
        {
            MatrixR = new TextBox[linha1,coluna2];
            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                { 
                    for(int n = 0 ; n < coluna1 ; n++)
                        {
                            double help = Convert.ToDouble(MatrixR[i, j].Text);
                            help += Convert.ToDouble(Matrix1[i,n].Text) * Convert.ToDouble(Matrix2[n,j].Text);
                            MatrixR[i, j].Text = Convert.ToString(help);
                        }
                    MatrixR[i, j] = new TextBox();
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 180;
                    MatrixR[i, j].Left = (j * 35) + 245;
                    MatrixR[i, j].Width = 30;
                    this.Controls.Add(MatrixR[i, j]);
                    
                }
            }

        }

       
        

        }//lastline
    }

