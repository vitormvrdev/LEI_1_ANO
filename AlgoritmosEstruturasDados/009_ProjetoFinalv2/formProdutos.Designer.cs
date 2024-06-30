namespace _009___Projeto_Final
{
    partial class formProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProdutos));
            btnExit = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnBack = new Button();
            label2 = new Label();
            btnInserir = new Button();
            btnEliminar = new Button();
            btnAlterar = new Button();
            lstProdutos = new ListView();
            cboxCategoria = new ComboBox();
            label3 = new Label();
            btnAtualizaLista = new Button();
            btnCalcular = new Button();
            txtBoxResultado = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(793, 1);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(57, 67);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 116);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 67);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 33);
            label1.TabIndex = 3;
            label1.Text = "Gestão de Vendas";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(48, 70, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 571);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 100);
            btnBack.TabIndex = 2;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(198, 211, 227);
            label2.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(227, 79);
            label2.Name = "label2";
            label2.Size = new Size(238, 57);
            label2.TabIndex = 3;
            label2.Text = "Produtos";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(48, 70, 116);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(14, 141);
            btnInserir.Margin = new Padding(2, 3, 2, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(162, 100);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(48, 70, 116);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(14, 400);
            btnEliminar.Margin = new Padding(2, 3, 2, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 100);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(14, 271);
            btnAlterar.Margin = new Padding(2, 3, 2, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(162, 100);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // lstProdutos
            // 
            lstProdutos.Location = new Point(227, 141);
            lstProdutos.Margin = new Padding(2, 3, 2, 3);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(526, 357);
            lstProdutos.TabIndex = 17;
            lstProdutos.UseCompatibleStateImageBehavior = false;
            lstProdutos.View = View.Details;
            // 
            // cboxCategoria
            // 
            cboxCategoria.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Location = new Point(208, 632);
            cboxCategoria.Margin = new Padding(2, 3, 2, 3);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(210, 39);
            cboxCategoria.TabIndex = 18;
            cboxCategoria.Text = "Categoria";
            cboxCategoria.SelectedIndexChanged += cboxCategoria_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(208, 584);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(477, 41);
            label3.TabIndex = 19;
            label3.Text = "Filtrar e Calcular por Categoria";
            // 
            // btnAtualizaLista
            // 
            btnAtualizaLista.BackColor = Color.FromArgb(48, 70, 116);
            btnAtualizaLista.FlatAppearance.BorderSize = 0;
            btnAtualizaLista.FlatStyle = FlatStyle.Flat;
            btnAtualizaLista.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizaLista.ForeColor = Color.White;
            btnAtualizaLista.Location = new Point(608, 518);
            btnAtualizaLista.Margin = new Padding(2, 3, 2, 3);
            btnAtualizaLista.Name = "btnAtualizaLista";
            btnAtualizaLista.Size = new Size(145, 32);
            btnAtualizaLista.TabIndex = 21;
            btnAtualizaLista.Text = "Atualizar Lista";
            btnAtualizaLista.UseVisualStyleBackColor = false;
            btnAtualizaLista.Click += btnAtualizaLista_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(48, 70, 116);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(424, 632);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(210, 44);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtBoxResultado
            // 
            txtBoxResultado.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxResultado.Location = new Point(642, 632);
            txtBoxResultado.Margin = new Padding(3, 4, 3, 4);
            txtBoxResultado.Name = "txtBoxResultado";
            txtBoxResultado.Size = new Size(180, 39);
            txtBoxResultado.TabIndex = 23;
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
            // formProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(850, 700);
            ControlBox = false;
            Controls.Add(txtBoxResultado);
            Controls.Add(btnCalcular);
            Controls.Add(btnAtualizaLista);
            Controls.Add(label3);
            Controls.Add(cboxCategoria);
            Controls.Add(lstProdutos);
            Controls.Add(btnAlterar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInserir);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formProdutos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Load += Produtos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Panel panel1;
        private Label label1;
        private Button btnBack;
        private Label label2;
        private Button btnInserir;
        private Button btnEliminar;
        private Button btnAlterar;
        private ListView lstProdutos;
        private ComboBox cboxCategoria;
        private Label label3;
        private Button btnAtualizaLista;
        private Button btnCalcular;
        private TextBox txtBoxResultado;
        private PictureBox pictureBox1;
    }
}