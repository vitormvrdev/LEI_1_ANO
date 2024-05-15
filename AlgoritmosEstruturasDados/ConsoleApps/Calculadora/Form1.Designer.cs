namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnPlus = new Button();
            Title = new Label();
            btnSubtract = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            firstNumber = new Label();
            secondNumber = new Label();
            firstNumbertxtBox = new TextBox();
            secondNumbertxtBox = new TextBox();
            resultLabel = new Label();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Variable Small Semilig", 12F, FontStyle.Bold);
            btnExit.Location = new Point(630, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 31);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlus
            // 
            btnPlus.Enabled = false;
            btnPlus.Font = new Font("Segoe UI", 24F);
            btnPlus.Location = new Point(88, 124);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 56);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 48F);
            Title.ForeColor = Color.Magenta;
            Title.Location = new Point(169, 9);
            Title.Name = "Title";
            Title.Size = new Size(475, 86);
            Title.TabIndex = 2;
            Title.Text = "CALCULADORA";
            // 
            // btnSubtract
            // 
            btnSubtract.Enabled = false;
            btnSubtract.Font = new Font("Segoe UI", 24F);
            btnSubtract.Location = new Point(88, 186);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 56);
            btnSubtract.TabIndex = 3;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnDivide
            // 
            btnDivide.Enabled = false;
            btnDivide.Font = new Font("Segoe UI", 24F);
            btnDivide.Location = new Point(88, 310);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 56);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Enabled = false;
            btnMultiply.Font = new Font("Segoe UI", 24F);
            btnMultiply.Location = new Point(88, 248);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 56);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // firstNumber
            // 
            firstNumber.AutoSize = true;
            firstNumber.Font = new Font("Segoe UI", 24F);
            firstNumber.ForeColor = Color.IndianRed;
            firstNumber.Location = new Point(247, 129);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(177, 45);
            firstNumber.TabIndex = 6;
            firstNumber.Text = "1º Número";
            // 
            // secondNumber
            // 
            secondNumber.AutoSize = true;
            secondNumber.Font = new Font("Segoe UI", 24F);
            secondNumber.ForeColor = Color.IndianRed;
            secondNumber.Location = new Point(528, 129);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(177, 45);
            secondNumber.TabIndex = 7;
            secondNumber.Text = "2º Número";
            // 
            // firstNumbertxtBox
            // 
            firstNumbertxtBox.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNumbertxtBox.Location = new Point(247, 199);
            firstNumbertxtBox.Name = "firstNumbertxtBox";
            firstNumbertxtBox.Size = new Size(177, 32);
            firstNumbertxtBox.TabIndex = 8;
            firstNumbertxtBox.TextChanged += firstNumbertxtBox_TextChanged;
            // 
            // secondNumbertxtBox
            // 
            secondNumbertxtBox.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNumbertxtBox.Location = new Point(528, 199);
            secondNumbertxtBox.Name = "secondNumbertxtBox";
            secondNumbertxtBox.Size = new Size(177, 32);
            secondNumbertxtBox.TabIndex = 9;
            secondNumbertxtBox.TextChanged += secondNumbertxtBox_TextChanged;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 24F);
            resultLabel.ForeColor = Color.IndianRed;
            resultLabel.Location = new Point(385, 248);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(160, 45);
            resultLabel.TabIndex = 10;
            resultLabel.Text = "Resultado";
            // 
            // resultTextBox
            // 
            resultTextBox.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(385, 310);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(160, 32);
            resultTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTextBox);
            Controls.Add(resultLabel);
            Controls.Add(secondNumbertxtBox);
            Controls.Add(firstNumbertxtBox);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtract);
            Controls.Add(Title);
            Controls.Add(btnPlus);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnPlus;
        private Label Title;
        private Button btnSubtract;
        private Button btnDivide;
        private Button btnMultiply;
        private Label firstNumber;
        private Label secondNumber;
        private TextBox firstNumbertxtBox;
        private TextBox secondNumbertxtBox;
        private Label resultLabel;
        private TextBox resultTextBox;
    }
}
