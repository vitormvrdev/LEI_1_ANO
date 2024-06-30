namespace _009___Projeto_Final
{
    partial class formInserirProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInserirProduto));
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            btnSalvar = new Button();
            btnBack = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxCodigo = new TextBox();
            txtBoxNome = new TextBox();
            txtBoxCategoria = new TextBox();
            txtBoxPreco = new TextBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 70, 116);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 67);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 20);
            label2.Name = "label2";
            label2.Size = new Size(194, 33);
            label2.TabIndex = 3;
            label2.Text = "Inserir Produto";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(733, 1);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(57, 67);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(48, 70, 116);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(666, 437);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 67);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(48, 70, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(14, 437);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 67);
            btnBack.TabIndex = 9;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(48, 70, 116);
            label1.Location = new Point(208, 145);
            label1.Name = "label1";
            label1.Size = new Size(97, 33);
            label1.TabIndex = 10;
            label1.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(208, 196);
            label3.Name = "label3";
            label3.Size = new Size(85, 33);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(48, 70, 116);
            label4.Location = new Point(208, 249);
            label4.Name = "label4";
            label4.Size = new Size(128, 33);
            label4.TabIndex = 12;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(48, 70, 116);
            label5.Location = new Point(208, 299);
            label5.Name = "label5";
            label5.Size = new Size(81, 33);
            label5.TabIndex = 13;
            label5.Text = "Preço";
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCodigo.Location = new Point(349, 153);
            txtBoxCodigo.Margin = new Padding(3, 4, 3, 4);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(233, 32);
            txtBoxCodigo.TabIndex = 14;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxNome.Location = new Point(349, 204);
            txtBoxNome.Margin = new Padding(3, 4, 3, 4);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(233, 32);
            txtBoxNome.TabIndex = 15;
            // 
            // txtBoxCategoria
            // 
            txtBoxCategoria.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCategoria.Location = new Point(349, 257);
            txtBoxCategoria.Margin = new Padding(3, 4, 3, 4);
            txtBoxCategoria.Name = "txtBoxCategoria";
            txtBoxCategoria.Size = new Size(233, 32);
            txtBoxCategoria.TabIndex = 16;
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPreco.Location = new Point(349, 307);
            txtBoxPreco.Margin = new Padding(3, 4, 3, 4);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(233, 32);
            txtBoxPreco.TabIndex = 17;
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
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // formInserirProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 232);
            ClientSize = new Size(800, 520);
            ControlBox = false;
            Controls.Add(txtBoxPreco);
            Controls.Add(txtBoxCategoria);
            Controls.Add(txtBoxNome);
            Controls.Add(txtBoxCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSalvar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "formInserirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button button1;
        private Button btnSalvar;
        private Button btnBack;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBoxCodigo;
        private TextBox txtBoxNome;
        private TextBox txtBoxCategoria;
        private TextBox txtBoxPreco;
        private PictureBox pictureBox1;
    }
}