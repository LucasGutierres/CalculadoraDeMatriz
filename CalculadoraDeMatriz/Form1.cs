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
       


        private void CreateMyOpaqueForm()
        {
            // Create a new form.
            Form form1 = new Form();
            // Set the text displayed in the caption.
            form1.Text = "My Form";
            // Set the opacity to 75%.
            form1.Opacity = .75;
            // Size the form to be 300 pixels in height and width.
            form1.Size = new Size(300, 300);
            // Display the form in the center of the screen.
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            form1.ShowDialog();
        }
        public Form1()
        {           
            InitializeComponent();
        }
        //butao criar --ok
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
        //reposicao da matriz 1 e 2 -- ok
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
                            Matrix2[i, j].Left -= Form1.ActiveForm.Width;
                            this.Controls.Remove(Matrix2[i, j]);
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
                        Matrix1[i, j].Text = Convert.ToString(i + j);
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
                        Matrix2[i, j].Text = "1";
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
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 290;
                        MatrixR[i, j].Left = (j * 35) + 290;
                        MatrixR[i, j].Width = 30;
                        this.Controls.Add(MatrixR[i,j]);
                    }

                }
                
            }
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
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 290;
                        MatrixR[i, j].Left = (j * 35) + 290;
                        MatrixR[i, j].Width = 30;
                        this.Controls.Add(MatrixR[i, j]);
                    }
                }
            }
        }
       
        //multiplicacao escalar -- ok
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
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 290;
                    MatrixR[i, j].Left = (j * 35) + 290;
                    MatrixR[i, j].Width = 30;
                    this.Controls.Add(MatrixR[i, j]);
                }
            }
        }
       
        //troca linah por coluna -- ok
        private void Transposta(object sender, EventArgs e)
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
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 290;
                    MatrixR[i, j].Left = (j * 35) + 290;
                    MatrixR[i, j].Width = 30;
                    this.Controls.Add(MatrixR[i, j]);
                }
            }
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
                            this.Controls.Remove(MatrixR[i, j]);

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
            if (coluna1 != linha1) {
                int m1L = linha2;
                int m1c = coluna2;
                int m2L = linha1;
                int m2c = coluna1;
                if (m1L != m2c) { Console.WriteLine("ERRO"); ok = false; }
                else
                  {
                      linha1 = m1L;
                      coluna1 = m1c;
                      linha2 = m2L;
                      coluna2 = m2c;
                      Console.WriteLine("ConcertoOk");
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
                                this.Controls.Remove(MatrixR[i, j]);

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
                        MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 290;
                        MatrixR[i, j].Left = (j * 35) + 290;
                        MatrixR[i, j].Width = 30; 
                        this.Controls.Add(MatrixR[i, j]);
                        CasasR = 0;

                    }
                }
            }
            
        }
       
        //determinante -- 
        private void Determin(object sender, EventArgs e)
        {
            double linhasP = 1;
            double linhasN = -1;
            double resultadoD1 = 0;
            double resultadoD2 = 0;
            double RespostaDeterminante = 5;
         
             if (coluna1 == linha1) {

                for (int i = 0; i < Matrix1.GetLength(0);i++ )
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
                        linhasN *= Convert.ToDouble(Matrix1[j, (((i + j) % coluna1))].Text);  
                    }
                    Console.WriteLine(linhasN);
                    resultadoD2 += (linhasN *-1);
                    linhasN = 1;
                }
                Console.WriteLine(resultadoD2);
                RespostaDeterminante = resultadoD1 + resultadoD2;
                Dtm_box.Text = Convert.ToString(RespostaDeterminante);
                
               
                
            }      
        }
       
        //verifica se é simetrica -- ok
        private void SimetricaVerific(object sender, EventArgs e)
        {
            bool simetriaOk = true;
            MatrixR = new TextBox[linha1, coluna2];
            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    if (Matrix1[i, j].Text == Matrix1[j, i].Text) {}
                    else { simetriaOk = false; }
                }
            }
            
            if (simetriaOk) Dtm_box.Text = " É simetrica !";
            else { Dtm_box.Text = " Não é simetrica"; }
        }

        private void Invert(object sender, EventArgs e)
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

            MatrixR = new TextBox[linha1, coluna1];

            for (int i = 0; i < MatrixR.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixR.GetLength(1); j++)
                {
                    if (i == j) { MatrixR[i, j].Text = Convert.ToString(1 / Convert.ToDouble(Matrix1[i, j].Text)); }
                    else { MatrixR[i, j].Text = Convert.ToString(0 / Convert.ToDouble(Matrix1[i, j].Text)); }
                    MatrixR[i,j] = new TextBox();
                    MatrixR[i, j].Top = (i * MatrixR[i, j].Height) + 180;
                    MatrixR[i, j].Left = (j * 35) + 245;
                    MatrixR[i, j].Width = 30;
                    this.Controls.Add(MatrixR[i, j]);
                }
            }


        }

        //quando eu apertar o botao que nescecita da matrizR , eu crio uma grupbox e tals e crio dois botoes em baixo dela vc sabe pra que , 
        //faz os bototes da outra matriz funcionar
        //bota as mensagens de erro
        //nao chora
        }//lastline
    }

