namespace WinFormsApp1
{
    partial class AddVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVenda));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnBack = new Button();
            btnSalvar = new Button();
            txtBoxCodProdVenda = new TextBox();
            txtBoxCodVendedor = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtQuantidadeVenda = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cboxZona = new ComboBox();
            txtValorVenda = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 116);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 50);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 15);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 3;
            label1.Text = "Gestão de Vendas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.open_box;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(788, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(48, 70, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 328);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(48, 70, 116);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(583, 328);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 50);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSave_Click;
            // 
            // txtBoxCodProdVenda
            // 
            txtBoxCodProdVenda.Font = new Font("Tahoma", 12F);
            txtBoxCodProdVenda.Location = new Point(340, 163);
            txtBoxCodProdVenda.Name = "txtBoxCodProdVenda";
            txtBoxCodProdVenda.Size = new Size(204, 27);
            txtBoxCodProdVenda.TabIndex = 25;
            // 
            // txtBoxCodVendedor
            // 
            txtBoxCodVendedor.Font = new Font("Tahoma", 12F);
            txtBoxCodVendedor.Location = new Point(340, 126);
            txtBoxCodVendedor.Name = "txtBoxCodVendedor";
            txtBoxCodVendedor.Size = new Size(204, 27);
            txtBoxCodVendedor.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F);
            label5.ForeColor = Color.FromArgb(48, 70, 116);
            label5.Location = new Point(156, 161);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 21;
            label5.Text = "Código Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F);
            label4.ForeColor = Color.FromArgb(48, 70, 116);
            label4.Location = new Point(156, 124);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 20;
            label4.Text = "Código Vendedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(156, 84);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 19;
            label3.Text = "Zona";
            // 
            // txtQuantidadeVenda
            // 
            txtQuantidadeVenda.Font = new Font("Tahoma", 12F);
            txtQuantidadeVenda.Location = new Point(340, 206);
            txtQuantidadeVenda.Name = "txtQuantidadeVenda";
            txtQuantidadeVenda.Size = new Size(204, 27);
            txtQuantidadeVenda.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 15.75F);
            label6.ForeColor = Color.FromArgb(48, 70, 116);
            label6.Location = new Point(156, 241);
            label6.Name = "label6";
            label6.Size = new Size(156, 25);
            label6.TabIndex = 27;
            label6.Text = "Valor da Venda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15.75F);
            label7.ForeColor = Color.FromArgb(48, 70, 116);
            label7.Location = new Point(156, 204);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 26;
            label7.Text = "Quantidade";
            // 
            // cboxZona
            // 
            cboxZona.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxZona.FormattingEnabled = true;
            cboxZona.Location = new Point(340, 84);
            cboxZona.Name = "cboxZona";
            cboxZona.Size = new Size(204, 33);
            cboxZona.TabIndex = 30;
            // 
            // txtValorVenda
            // 
            txtValorVenda.Font = new Font("Tahoma", 12F);
            txtValorVenda.Location = new Point(340, 241);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(204, 27);
            txtValorVenda.TabIndex = 31;
            // 
            // AddVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(700, 390);
            ControlBox = false;
            Controls.Add(txtValorVenda);
            Controls.Add(cboxZona);
            Controls.Add(txtQuantidadeVenda);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtBoxCodProdVenda);
            Controls.Add(txtBoxCodVendedor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSalvar);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddVenda";
            Text = "AddVenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnBack;
        private Button btnSalvar;
        private TextBox txtBoxCodProdVenda;
        private TextBox txtBoxCodVendedor;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtQuantidadeVenda;
        private Label label6;
        private Label label7;
        private ComboBox cboxZona;
        private TextBox txtValorVenda;
    }
}