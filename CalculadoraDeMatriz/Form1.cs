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
        public int linha1;
        public int coluna1;
        public int linha2;
        public int coluna2;
        public int colunaResposta;
        public int linhaResposta;
        private TextBox[,] Matrix1;
        private TextBox[,] Matrix2;
        private TextBox[,] MatrixR;

        public Form1()
        {
           
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                linha1 = Convert.ToInt16(matriz1_Linha.Text);
                coluna1 = Convert.ToInt16(matriz1_Coluna.Text);
                linha2 = Convert.ToInt16(matriz2_Linha.Text);
                coluna2 = Convert.ToInt16(matriz2_Coluna.Text);

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
       


        }//lastline
    }

