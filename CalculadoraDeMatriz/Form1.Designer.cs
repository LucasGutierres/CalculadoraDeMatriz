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
            this.QuoeficienteME = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(355, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mariz2_Nome
            // 
            this.mariz2_Nome.AutoSize = true;
            this.mariz2_Nome.Location = new System.Drawing.Point(742, 9);
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
            this.matriz2_Coluna.Location = new System.Drawing.Point(779, 25);
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
            this.matriz2_Linha.Location = new System.Drawing.Point(709, 25);
            this.matriz2_Linha.Name = "matriz2_Linha";
            this.matriz2_Linha.Size = new System.Drawing.Size(44, 21);
            this.matriz2_Linha.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // SumButton
            // 
            this.SumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumButton.Location = new System.Drawing.Point(355, 51);
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
            this.MinButton.Location = new System.Drawing.Point(402, 51);
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
            this.button2.Location = new System.Drawing.Point(402, 107);
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
            this.label2.Location = new System.Drawing.Point(369, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Escalar";
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
            this.button3.Location = new System.Drawing.Point(355, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "Simetrica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Simetria);
            // 
            // QuoeficienteME
            // 
            this.QuoeficienteME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoeficienteME.Location = new System.Drawing.Point(355, 108);
            this.QuoeficienteME.Name = "QuoeficienteME";
            this.QuoeficienteME.Size = new System.Drawing.Size(28, 26);
            this.QuoeficienteME.TabIndex = 18;
            this.QuoeficienteME.Text = "1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(436, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 30);
            this.button4.TabIndex = 19;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Mult);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 398);
            this.Controls.Add(this.button4);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox QuoeficienteME;
        private System.Windows.Forms.Button button4;
    }
}

