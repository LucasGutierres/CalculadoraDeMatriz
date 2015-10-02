namespace CalculadoraDeMatriz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matriz1_X = new System.Windows.Forms.Label();
            this.matriz1_Nome = new System.Windows.Forms.Label();
            this.matriz1_Coluna = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mariz2_Nome = new System.Windows.Forms.Label();
            this.matriz2_Coluna = new System.Windows.Forms.ComboBox();
            this.matriz2_Linha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SumButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.matriz1_Linha = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Dtm_box = new System.Windows.Forms.TextBox();
            this.QuoeficienteME = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // matriz1_X
            // 
            this.matriz1_X.AutoSize = true;
            this.matriz1_X.Location = new System.Drawing.Point(62, 28);
            this.matriz1_X.Name = "matriz1_X";
            this.matriz1_X.Size = new System.Drawing.Size(14, 13);
            this.matriz1_X.TabIndex = 2;
            this.matriz1_X.Text = "X";
            // 
            // matriz1_Nome
            // 
            this.matriz1_Nome.AutoSize = true;
            this.matriz1_Nome.Location = new System.Drawing.Point(12, 9);
            this.matriz1_Nome.Name = "matriz1_Nome";
            this.matriz1_Nome.Size = new System.Drawing.Size(75, 13);
            this.matriz1_Nome.TabIndex = 3;
            this.matriz1_Nome.Text = "Primeira Matriz";
            // 
            // matriz1_Coluna
            // 
            this.matriz1_Coluna.AccessibleDescription = "";
            this.matriz1_Coluna.AccessibleName = "";
            this.matriz1_Coluna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matriz1_Coluna.FormattingEnabled = true;
            this.matriz1_Coluna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.matriz1_Coluna.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.matriz1_Coluna.Location = new System.Drawing.Point(82, 25);
            this.matriz1_Coluna.Name = "matriz1_Coluna";
            this.matriz1_Coluna.Size = new System.Drawing.Size(44, 21);
            this.matriz1_Coluna.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mariz2_Nome
            // 
            this.mariz2_Nome.AutoSize = true;
            this.mariz2_Nome.Location = new System.Drawing.Point(881, 9);
            this.mariz2_Nome.Name = "mariz2_Nome";
            this.mariz2_Nome.Size = new System.Drawing.Size(81, 13);
            this.mariz2_Nome.TabIndex = 8;
            this.mariz2_Nome.Text = "Segunda Matriz";
            // 
            // matriz2_Coluna
            // 
            this.matriz2_Coluna.AccessibleDescription = "";
            this.matriz2_Coluna.AccessibleName = "";
            this.matriz2_Coluna.DisplayMember = "(none)";
            this.matriz2_Coluna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matriz2_Coluna.FormattingEnabled = true;
            this.matriz2_Coluna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.matriz2_Coluna.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.matriz2_Coluna.Location = new System.Drawing.Point(918, 26);
            this.matriz2_Coluna.Name = "matriz2_Coluna";
            this.matriz2_Coluna.Size = new System.Drawing.Size(44, 21);
            this.matriz2_Coluna.TabIndex = 11;
            // 
            // matriz2_Linha
            // 
            this.matriz2_Linha.AccessibleDescription = "";
            this.matriz2_Linha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matriz2_Linha.FormattingEnabled = true;
            this.matriz2_Linha.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.matriz2_Linha.Location = new System.Drawing.Point(848, 25);
            this.matriz2_Linha.Name = "matriz2_Linha";
            this.matriz2_Linha.Size = new System.Drawing.Size(44, 21);
            this.matriz2_Linha.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumButton.Location = new System.Drawing.Point(514, 64);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(28, 30);
            this.SumButton.TabIndex = 12;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinButton.Location = new System.Drawing.Point(419, 64);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(28, 30);
            this.MinButton.TabIndex = 13;
            this.MinButton.Text = "-";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(49, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MultEscalar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "MultiplicaçãoEscalar";
            // 
            // matriz1_Linha
            // 
            this.matriz1_Linha.AccessibleDescription = "";
            this.matriz1_Linha.AccessibleName = "";
            this.matriz1_Linha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matriz1_Linha.FormattingEnabled = true;
            this.matriz1_Linha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.matriz1_Linha.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.matriz1_Linha.Location = new System.Drawing.Point(12, 25);
            this.matriz1_Linha.Name = "matriz1_Linha";
            this.matriz1_Linha.Size = new System.Drawing.Size(44, 21);
            this.matriz1_Linha.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Transposta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Transposta);
            // 
            // Dtm_box
            // 
            this.Dtm_box.Location = new System.Drawing.Point(177, 412);
            this.Dtm_box.Name = "Dtm_box";
            this.Dtm_box.Size = new System.Drawing.Size(156, 20);
            this.Dtm_box.TabIndex = 19;
            // 
            // QuoeficienteME
            // 
            this.QuoeficienteME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoeficienteME.Location = new System.Drawing.Point(15, 412);
            this.QuoeficienteME.Name = "QuoeficienteME";
            this.QuoeficienteME.Size = new System.Drawing.Size(28, 26);
            this.QuoeficienteME.TabIndex = 18;
            this.QuoeficienteME.Text = "1";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(258, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 21;
            this.button6.Text = "smtc ?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SimetricaVerific);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(96, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 22;
            this.button7.Text = "Inversa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Invert);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(468, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 30);
            this.button4.TabIndex = 23;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Mult);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(177, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 24;
            this.button5.Text = "Determinante";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Determin);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 304);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(603, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 304);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz 2";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(614, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 29);
            this.button8.TabIndex = 29;
            this.button8.Text = "Transposta";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(695, 364);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 28);
            this.button9.TabIndex = 30;
            this.button9.Text = "Inversa";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(793, 364);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 28);
            this.button10.TabIndex = 31;
            this.button10.Text = "Determinante";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(874, 364);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 28);
            this.button11.TabIndex = 32;
            this.button11.Text = "smtc ?";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(614, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(845, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "MultiplicaçãoEscalar";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(848, 426);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 26);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "1";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(884, 424);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(28, 29);
            this.button12.TabIndex = 36;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(298, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 304);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matriz 2";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(974, 800);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Dtm_box);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.QuoeficienteME);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.matriz1_Linha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.matriz2_Coluna);
            this.Controls.Add(this.matriz2_Linha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mariz2_Nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matriz1_Coluna);
            this.Controls.Add(this.matriz1_Nome);
            this.Controls.Add(this.matriz1_X);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "CalculadoraDeMatrizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matriz1_X;
        private System.Windows.Forms.Label matriz1_Nome;
        private System.Windows.Forms.ComboBox matriz1_Coluna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mariz2_Nome;
        private System.Windows.Forms.ComboBox matriz2_Coluna;
        private System.Windows.Forms.ComboBox matriz2_Linha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox matriz1_Linha;
        private System.Windows.Forms.Button button3;

     
        private System.Windows.Forms.TextBox Dtm_box;

        private System.Windows.Forms.TextBox QuoeficienteME;
        
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}

