namespace _009___Projeto_Final
{
    partial class formAlterarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlterarProduto));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnBack = new Button();
            btnAlterar = new Button();
            txtBoxPreco = new TextBox();
            txtBoxCategoria = new TextBox();
            txtBoxCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnVoltar = new Button();
            cboxNomeAlterar = new ComboBox();
            btnAlterarDados = new Button();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(196, 33);
            label1.TabIndex = 3;
            label1.Text = "Alterar Produto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(10, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(729, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(57, 67);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnVoltar_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(48, 70, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(14, 817);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 100);
            btnBack.TabIndex = 3;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(795, 817);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(162, 100);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Voltar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPreco.Location = new Point(354, 323);
            txtBoxPreco.Margin = new Padding(3, 4, 3, 4);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(233, 32);
            txtBoxPreco.TabIndex = 25;
            // 
            // txtBoxCategoria
            // 
            txtBoxCategoria.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCategoria.Location = new Point(354, 273);
            txtBoxCategoria.Margin = new Padding(3, 4, 3, 4);
            txtBoxCategoria.Name = "txtBoxCategoria";
            txtBoxCategoria.Size = new Size(233, 32);
            txtBoxCategoria.TabIndex = 24;
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCodigo.Location = new Point(354, 229);
            txtBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(233, 32);
            txtBoxCodigo.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(48, 70, 116);
            label5.Location = new Point(214, 315);
            label5.Name = "label5";
            label5.Size = new Size(81, 33);
            label5.TabIndex = 21;
            label5.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(48, 70, 116);
            label4.Location = new Point(214, 265);
            label4.Name = "label4";
            label4.Size = new Size(128, 33);
            label4.TabIndex = 20;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(214, 177);
            label3.Name = "label3";
            label3.Size = new Size(85, 33);
            label3.TabIndex = 19;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(214, 221);
            label2.Name = "label2";
            label2.Size = new Size(97, 33);
            label2.TabIndex = 18;
            label2.Text = "Código";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(48, 70, 116);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(14, 437);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 67);
            btnVoltar.TabIndex = 26;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // cboxNomeAlterar
            // 
            cboxNomeAlterar.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboxNomeAlterar.FormattingEnabled = true;
            cboxNomeAlterar.Location = new Point(354, 180);
            cboxNomeAlterar.Margin = new Padding(3, 4, 3, 4);
            cboxNomeAlterar.Name = "cboxNomeAlterar";
            cboxNomeAlterar.Size = new Size(233, 37);
            cboxNomeAlterar.TabIndex = 27;
            // 
            // btnAlterarDados
            // 
            btnAlterarDados.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterarDados.FlatAppearance.BorderSize = 0;
            btnAlterarDados.FlatStyle = FlatStyle.Flat;
            btnAlterarDados.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterarDados.ForeColor = Color.White;
            btnAlterarDados.Location = new Point(666, 437);
            btnAlterarDados.Margin = new Padding(3, 4, 3, 4);
            btnAlterarDados.Name = "btnAlterarDados";
            btnAlterarDados.Size = new Size(120, 67);
            btnAlterarDados.TabIndex = 28;
            btnAlterarDados.Text = "Alterar";
            btnAlterarDados.UseVisualStyleBackColor = false;
            btnAlterarDados.Click += btnAlterarDados_Click;
            // 
            // formAlterarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 520);
            ControlBox = false;
            Controls.Add(btnAlterarDados);
            Controls.Add(cboxNomeAlterar);
            Controls.Add(btnVoltar);
            Controls.Add(txtBoxPreco);
            Controls.Add(txtBoxCategoria);
            Controls.Add(txtBoxCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAlterar);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formAlterarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarProduto";
            Load += AlterarProduto_Load;
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
        private Button btnAlterar;
        private TextBox txtBoxPreco;
        private TextBox txtBoxCategoria;
        private TextBox txtBoxCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnVoltar;
        private ComboBox cboxNomeAlterar;
        private Button btnAlterarDados;
    }
}