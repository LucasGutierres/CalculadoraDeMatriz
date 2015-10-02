using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Dynamic;
using System.Text.RegularExpressions;


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
        public string matrizReferente;
        /*
        private int diferenciadorL1 = 0;
        private int diferenciadorC1 = 0;
        private int diferenciadorL2;
        private int diferenciadorC2;
        //ajeitar
        private bool recriarM1 = true;
        private bool recriarM2 = true;
        */

        public Form1()
        {           
            InitializeComponent();
            Matrix1 = new TextBox[0, 0];
            Matrix2 = new TextBox[0, 0];
        }
        
        //butao criar --ok
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (diferenciadorL1 == matriz1_Linha.SelectedIndex) { recriarM1 = false; } else { recriarM1 = true; }
            if (diferenciadorC1 == matriz1_Coluna.SelectedIndex) { recriarM1 = false; } else { recriarM1 = true; }
            if (diferenciadorL2 == matriz2_Linha.SelectedIndex) { recriarM2 = false; } else { recriarM2 = true; }
            if (diferenciadorC2 == matriz2_Coluna.SelectedIndex) { recriarM2 = false; } else { recriarM2 = true; }

            diferenciadorL1 = matriz1_Linha.SelectedIndex;
            diferenciadorC1 = matriz1_Coluna.SelectedIndex;
            diferenciadorL2 = matriz2_Linha.SelectedIndex;
            diferenciadorC2 = matriz2_Coluna.SelectedIndex;
            */
            if (matriz1_Linha.SelectedIndex == -1) linha1 = 0; else linha1 = Convert.ToInt32(matriz1_Linha.Text);
            if (matriz1_Coluna.SelectedIndex == -1) coluna1 = 0; else coluna1 = Convert.ToInt32(matriz1_Coluna.Text);
            if (matriz2_Linha.SelectedIndex == -1) linha2 = 0; else linha2 = Convert.ToInt16(matriz2_Linha.Text);
            if (matriz2_Coluna.SelectedIndex == -1) coluna2 = 0; else coluna2 = Convert.ToInt16(matriz2_Coluna.Text);

                TextBoxOverride();
                Matrix1 = new TextBox[linha1, coluna1];
                Matrix2 = new TextBox[linha2, coluna2];
                Criar();
        }
        //reposicao da matriz 1 e 2 -- ok
        void TextBoxOverride() {

        
                if (Matrix1 != null)
                {
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            if (Matrix1[i, j] != null)
                                groupBox1.Controls.Remove(Matrix1[i, j]);
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
                                Matrix2[i, j].Left -= Form1.ActiveForm.Width;
                            groupBox1.Controls.Remove(Matrix2[i, j]);
                        }
                    }
                }
            
        }
        //criação das matrizes 1 e 2 -- ok
        void Criar() {
            Console.WriteLine(Form1.ActiveForm.Width);
               
               
                
                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        
                        Matrix1[i, j] = new TextBox();
                        Matrix1[i, j].Text = "";
                        Matrix1[i, j].Top = 10 + (i*30);
                        Matrix1[i, j].Left = (j * 35) + 10;
                        Matrix1[i, j].Width = 30;
                        groupBox1.Controls.Add(Matrix1[i,j]);
                    }
                }
                 for (int i = 0; i < Matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix2.GetLength(1); j++)
                    {
                        Matrix2[i, j] = new TextBox();
                        Matrix2[i, j].Text = "";
                        Matrix2[i, j].Top = 10 + (i * 30);
                        Matrix2[i, j].Left = (j * 35) + 10;
                        Matrix2[i, j].Width = 30;
                        groupBox2.Controls.Add(Matrix2[i, j]);
                    }
                }
            }
        //soma -- ok
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
                            groupBox3.Controls.Remove(MatrixR[i, j]);
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
                        MatrixR[i, j].Top = 10 + (i * 30); ;
                        MatrixR[i, j].Left = (j * 35) + 10;
                        MatrixR[i, j].Width = 30;
                        groupBox3.Controls.Add(MatrixR[i,j]);
                    }

                }

            }
            else { MessageBox.Show("É necessario que as matrizes tenham o mesmo tamanho"); }
        }
       
        //subtração -- ok
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
                            groupBox3.Controls.Remove(MatrixR[i, j]);
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
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 10;
                        MatrixR[i, j].Left = (j * 35) + 10;
                        MatrixR[i, j].Width = 30;
                        groupBox3.Controls.Add(MatrixR[i, j]);
                    }
                }
            }
            else { MessageBox.Show("É necessario que as matrizes tenham o mesmo tamanho"); }
        }

        //multiplicação -- ok
        private void Mult(object sender, EventArgs e)
        {
            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            groupBox3.Controls.Remove(MatrixR[i, j]);

                    }
                }
            }
            linhaResposta = linha1;
            colunaResposta = coluna2;
            MatrixR = new TextBox[linha1, coluna2];
            double CasasR = 0;
            bool ok = false;
            //enche essa bregueça de ifs
            if (coluna1 == linha2) ok = true;
            if (coluna1 != linha1)
            {
                int m1L = linha2;
                int m1c = coluna2;
                int m2L = linha1;
                int m2c = coluna1;
                if (m1L != m2c) { MessageBox.Show("Impossivel Multiplicar Essas Matrizes"); ; ok = false; }
                else
                {
                    linha1 = m1L;
                    coluna1 = m1c;
                    linha2 = m2L;
                    coluna2 = m2c;
                    MessageBox.Show("A ordem das matrizes foi alterada para tornar possivel a multiplicação");
                    ok = true;
                }
            }

            if (ok)
            {
                if (MatrixR != null)
                {
                    for (int i = 0; i < MatrixR.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrixR.GetLength(1); j++)
                        {
                            if (MatrixR[i, j] != null)
                                groupBox3.Controls.Remove(MatrixR[i, j]);

                        }
                    }
                }

                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {

                        for (int n = 0; n < coluna1; n++)
                        {
                            CasasR += Convert.ToDouble(Matrix1[i, n].Text) * Convert.ToDouble(Matrix2[n, j].Text);
                        }
                        MatrixR[i, j] = new TextBox();
                        MatrixR[i, j].Text = Convert.ToString(CasasR);
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 10;
                        MatrixR[i, j].Left = (j * 35) + 10;
                        MatrixR[i, j].Width = 30;
                        groupBox3.Controls.Add(MatrixR[i, j]);
                        CasasR = 0;

                    }
                }
            }

        }
       
        //multiplicacao escalar -- ok
        private void MultEscalarM1(object sender, EventArgs e)
        {
            matrizReferente = "Matriz1";
            MultEscal();
        }
        private void MultEscalarM2(object sender, EventArgs e)
        {
            matrizReferente = "Matriz2";
            MultEscal();
        } 
        private void MultEscal()
        {
            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            groupBox3.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }
            if (matrizReferente == "Matriz1") {
                MatrixR = new TextBox[linha1, coluna1];
                multEscalar = Convert.ToInt16(QuoeficienteME.Text);
            }
            else if (matrizReferente == "Matriz2") {
                MatrixR = new TextBox[linha2, coluna2];
                multEscalar = Convert.ToInt16(textBox2.Text);
            }
            
            

            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                {
                    MatrixR[i, j] = new TextBox();
                    if(matrizReferente == "Matriz1")MatrixR[i, j].Text = Convert.ToString(Convert.ToInt32(Matrix1[i, j].Text) * multEscalar);
                    else if (matrizReferente == "Matriz2") MatrixR[i, j].Text = Convert.ToString(Convert.ToInt32(Matrix2[i, j].Text) * multEscalar);
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 10;
                    MatrixR[i, j].Left = (j * 35) + 10;
                    MatrixR[i, j].Width = 30;
                    groupBox3.Controls.Add(MatrixR[i, j]);
                }
            }
        }
        
        //troca linha por coluna -- ok
        private void Transposta()
        {
            
            if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            groupBox3.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }
            
            MatrixR = new TextBox[coluna1,linha1];

            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                {
                    MatrixR[i, j] = new TextBox();
                    if(matrizReferente == "Matriz1")MatrixR[i, j].Text = Convert.ToString(Matrix1[j,i].Text);
                    else if (matrizReferente == "Matriz2") MatrixR[i, j].Text = Convert.ToString(Matrix2[j, i].Text);
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 10;
                    MatrixR[i, j].Left = (j * 35) + 10;
                    MatrixR[i, j].Width = 30;
                    groupBox3.Controls.Add(MatrixR[i, j]);
                }
            }
        }
        private void TranspostaM1(object sender, EventArgs e)
        {
            matrizReferente = "Matriz1";
            if(Matrix1.GetLength(0) > 0 && Matrix1.GetLength(1) > 0)Transposta();
            else { MessageBox.Show("Crie a matriz primeiro"); }
        }
        private void TranspostaM2(object sender, EventArgs e)
        {
            matrizReferente = "Matriz2";
            if (Matrix2.GetLength(0) > 0 && Matrix2.GetLength(1) > 0) Transposta();
            else { MessageBox.Show("Crie a matriz primeiro"); }
        }
       
        //determinante -- 
        private void Determin()
        {
            double linhasP = 1;
            double linhasN = -1;
            double resultadoD1 = 0;
            double resultadoD2 = 0;
            double RespostaDeterminante = 5;
           
            if (matrizReferente == "Matriz1") {

                if (coluna1 == linha1 && coluna1 != 0 )
                {

                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            linhasP *= Convert.ToDouble(Matrix1[j, (((i + j) % coluna1))].Text);
                        }
                        resultadoD1 += linhasP;
                        linhasP = 1;
                    }
                    Console.WriteLine(resultadoD1);
                    //\/ ta dando erro na hr de selecionar as casas , concerta
                    for (int i = Matrix1.GetLength(0) - 1; i > 0; i--)
                    {
                        for (int j = Matrix1.GetLength(1) - 1; j >= 0; j--)
                        {
                            linhasN *= Convert.ToDouble(Matrix1[i, (((i + j) % linha1))].Text);
                        }
                        Console.WriteLine(linhasN);
                        resultadoD2 += (linhasN * -1);
                        linhasN = 1;
                    }
                    Console.WriteLine(resultadoD2);
                    RespostaDeterminante = resultadoD1 + resultadoD2;
                    Dtm_boxM1.Text = Convert.ToString(RespostaDeterminante);
                }
                else { MessageBox.Show("Para se obter um determinante é necessario que a matriz exista e seja quadrada. Ex : 3x3"); }
                
            }
            else if (matrizReferente == "Matriz2") {

                if (coluna2 == linha2 && coluna2 != 0)
                {

                    for (int i = 0; i < Matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            linhasP *= Convert.ToDouble(Matrix2[j, (((i + j) % coluna2))].Text);
                        }
                        resultadoD1 += linhasP;
                        linhasP = 1;
                    }
                    Console.WriteLine(resultadoD1);
                    //\/ ta dando erro na hr de selecionar as casas , concerta
                    for (int i = Matrix2.GetLength(0) - 1; i > 0; i--)
                    {
                        for (int j = Matrix2.GetLength(1) - 1; j >= 0; j--)
                        {
                            linhasN *= Convert.ToDouble(Matrix2[i, (((i + j) % linha2))].Text);
                        }
                        Console.WriteLine(linhasN);
                        resultadoD2 += (linhasN * -1);
                        linhasN = 1;
                    }
                    Console.WriteLine(resultadoD2);
                    RespostaDeterminante = resultadoD1 + resultadoD2;
                    Dtm_boxM2.Text = Convert.ToString(RespostaDeterminante);
                }
                else { MessageBox.Show("Para se obter um determinante é necessario que a matriz exista e seja quadrada. Ex : 3x3"); }
            
            }
            
        }
        private void DeterminM1(object sender, EventArgs e)
        {
            matrizReferente = "Matriz1";
            Determin();
        }
        private void DeterminM2(object sender, EventArgs e)
        {
            matrizReferente = "Matriz2";
            Determin();
        }
       
        //verifica se é simetrica -- ok
        private void SimetricaVerific()
        {
            if (Matrix1.GetLength(0) == Matrix1.GetLength(1) || Matrix2.GetLength(0) == Matrix1.GetLength(1))
            { 
               
                if (matrizReferente == "Matriz1") {
                
                    bool simetriaOk = true;
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            if (Matrix1[i, j].Text == Matrix1[j, i].Text) { }
                            else { simetriaOk = false; }
                        }
                    }
                    if (simetriaOk) Dtm_boxM1.Text = " É simetrica !";
                    else { Dtm_boxM1.Text = " Não é simetrica"; }
            
                }
                else if (matrizReferente == "Matriz2") {

                    bool simetriaOk = true;
                    for (int i = 0; i < Matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            if (Matrix2[i, j].Text == Matrix2[j, i].Text) { }
                            else { simetriaOk = false; }
                        }
                    }

                    if (simetriaOk) Dtm_boxM2.Text = " É simetrica !";
                    else { Dtm_boxM2.Text = " Não é simetrica"; }
                }
            }
            else {
                if (matrizReferente == "Matriz1") { Dtm_boxM1.Text = " Não é simetrica"; }
                if (matrizReferente == "Matriz2") { Dtm_boxM2.Text = " Não é simetrica"; }
            }
        }
        private void SimetricaVerificM1(object sender, EventArgs e)
        {
            matrizReferente = "Matriz1";
            if (Matrix1.GetLength(0) > 0) { SimetricaVerific(); }
            
        }
        private void SimetricaVerificM2(object sender, EventArgs e)
        {
            matrizReferente = "Matriz2";
            if (Matrix2.GetLength(0) > 0) { SimetricaVerific(); }
        }

        //Infuncional :/
        private void Invert(object sender, EventArgs e)
        {
            MessageBox.Show("Função indisponivel no momento");
            /*if (MatrixR != null)
            {
                for (int i = 0; i < MatrixR.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixR.GetLength(1); j++)
                    {
                        if (MatrixR[i, j] != null)
                            groupBox3.Controls.Remove(MatrixR[i, j]);
                    }
                }
            }

            MatrixR = new TextBox[linha1, coluna1];

            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                {
                    if (i == j) { MatrixR[i, j].Text = Convert.ToString(1 / Convert.ToDouble(Matrix1[i, j].Text)); }
                    else { MatrixR[i, j].Text = Convert.ToString(0 / Convert.ToDouble(Matrix1[i, j].Text)); }
                    MatrixR[i,j] = new TextBox();
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 10;
                    MatrixR[i, j].Left = (j * 35) + 10;
                    MatrixR[i, j].Width = 30;
                    groupBox3.Controls.Add(MatrixR[i, j]);
                }
            }*/


        }

        private void InversaM2(object sender, EventArgs e)
        {
            MessageBox.Show("Funcao indisponivel no moemnto");
        }
        //TextBox -- OK
        private void QuoeficienteME_TextChanged(object sender, EventArgs e)
        {
            QuoeficienteME.Text = Regex.Replace(Convert.ToString(QuoeficienteME.Text), "[^0-9]", "");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Regex.Replace(Convert.ToString(textBox2.Text), "[^0-9]", "");
        }









    

        



        //quando eu apertar o botao que nescecita da matrizR , eu crio uma grupbox e tals e crio dois botoes em baixo dela vc sabe pra que , 
        //faz os bototes da outra matriz funcionar
        //bota as mensagens de erro
        //nao chora
        }//lastline
    }

