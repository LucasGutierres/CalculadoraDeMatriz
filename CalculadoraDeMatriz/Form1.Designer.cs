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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.matriz1_Col = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // matriz1_X
            // 
            this.matriz1_X.AutoSize = true;
            this.matriz1_X.Location = new System.Drawing.Point(380, 61);
            this.matriz1_X.Name = "matriz1_X";
            this.matriz1_X.Size = new System.Drawing.Size(14, 13);
            this.matriz1_X.TabIndex = 2;
            this.matriz1_X.Text = "X";
            // 
            // matriz1_Nome
            // 
            this.matriz1_Nome.AutoSize = true;
            this.matriz1_Nome.Location = new System.Drawing.Point(351, 42);
            this.matriz1_Nome.Name = "matriz1_Nome";
            this.matriz1_Nome.Size = new System.Drawing.Size(75, 13);
            this.matriz1_Nome.TabIndex = 3;
            this.matriz1_Nome.Text = "Primeira Matriz";
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleDescription = "";
            this.comboBox1.AccessibleName = "";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(400, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // matriz1_Col
            // 
            this.matriz1_Col.AccessibleDescription = "";
            this.matriz1_Col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matriz1_Col.FormattingEnabled = true;
            this.matriz1_Col.Items.AddRange(new object[] {
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
            this.matriz1_Col.Location = new System.Drawing.Point(330, 57);
            this.matriz1_Col.Name = "matriz1_Col";
            this.matriz1_Col.Size = new System.Drawing.Size(44, 21);
            this.matriz1_Col.TabIndex = 5;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 457);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.matriz1_Col);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox matriz1_Col;
    }
}

