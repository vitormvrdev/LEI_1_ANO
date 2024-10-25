namespace ProjetoAula
{
    partial class FormFornecedor
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
            this.listaFornecedorButton = new System.Windows.Forms.Button();
            this.fornecedoresListBox = new System.Windows.Forms.ListBox();
            this.codigoFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.codigoFornecedorLabel = new System.Windows.Forms.Label();
            this.nomeFornecedorLabel = new System.Windows.Forms.Label();
            this.nomeFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaFornecedorButton
            // 
            this.listaFornecedorButton.Location = new System.Drawing.Point(77, 38);
            this.listaFornecedorButton.Margin = new System.Windows.Forms.Padding(2);
            this.listaFornecedorButton.Name = "listaFornecedorButton";
            this.listaFornecedorButton.Size = new System.Drawing.Size(123, 34);
            this.listaFornecedorButton.TabIndex = 0;
            this.listaFornecedorButton.Text = "button1";
            this.listaFornecedorButton.UseVisualStyleBackColor = true;
            this.listaFornecedorButton.Click += new System.EventHandler(this.listaFornecedorButton_Click);
            // 
            // fornecedoresListBox
            // 
            this.fornecedoresListBox.FormattingEnabled = true;
            this.fornecedoresListBox.Location = new System.Drawing.Point(338, 47);
            this.fornecedoresListBox.Name = "fornecedoresListBox";
            this.fornecedoresListBox.Size = new System.Drawing.Size(120, 95);
            this.fornecedoresListBox.TabIndex = 1;
            // 
            // codigoFornecedorTextBox
            // 
            this.codigoFornecedorTextBox.Location = new System.Drawing.Point(204, 194);
            this.codigoFornecedorTextBox.Name = "codigoFornecedorTextBox";
            this.codigoFornecedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoFornecedorTextBox.TabIndex = 2;
            this.codigoFornecedorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigoFornecedorTextBox_KeyUp);
            // 
            // codigoFornecedorLabel
            // 
            this.codigoFornecedorLabel.AutoSize = true;
            this.codigoFornecedorLabel.Location = new System.Drawing.Point(116, 197);
            this.codigoFornecedorLabel.Name = "codigoFornecedorLabel";
            this.codigoFornecedorLabel.Size = new System.Drawing.Size(47, 13);
            this.codigoFornecedorLabel.TabIndex = 3;
            this.codigoFornecedorLabel.Text = "Codigo:*";
            // 
            // nomeFornecedorLabel
            // 
            this.nomeFornecedorLabel.AutoSize = true;
            this.nomeFornecedorLabel.Location = new System.Drawing.Point(116, 253);
            this.nomeFornecedorLabel.Name = "nomeFornecedorLabel";
            this.nomeFornecedorLabel.Size = new System.Drawing.Size(42, 13);
            this.nomeFornecedorLabel.TabIndex = 4;
            this.nomeFornecedorLabel.Text = "Nome:*";
            // 
            // nomeFornecedorTextBox
            // 
            this.nomeFornecedorTextBox.Location = new System.Drawing.Point(204, 253);
            this.nomeFornecedorTextBox.Name = "nomeFornecedorTextBox";
            this.nomeFornecedorTextBox.Size = new System.Drawing.Size(226, 20);
            this.nomeFornecedorTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomeFornecedorTextBox);
            this.Controls.Add(this.nomeFornecedorLabel);
            this.Controls.Add(this.codigoFornecedorLabel);
            this.Controls.Add(this.codigoFornecedorTextBox);
            this.Controls.Add(this.fornecedoresListBox);
            this.Controls.Add(this.listaFornecedorButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFornecedor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listaFornecedorButton;
        private System.Windows.Forms.ListBox fornecedoresListBox;
        private System.Windows.Forms.TextBox codigoFornecedorTextBox;
        private System.Windows.Forms.Label codigoFornecedorLabel;
        private System.Windows.Forms.Label nomeFornecedorLabel;
        private System.Windows.Forms.TextBox nomeFornecedorTextBox;
        private System.Windows.Forms.Button button1;
    }
}

