namespace WinFormsApp1
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            btnExit = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(641, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            panel1.TabIndex = 1;
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
            btnBack.TabIndex = 2;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(198, 211, 227);
            label2.Font = new Font("Tahoma", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(151, 53);
            label2.Name = "label2";
            label2.Size = new Size(191, 46);
            label2.TabIndex = 3;
            label2.Text = "Produtos";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(48, 70, 116);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(12, 106);
            btnInserir.Margin = new Padding(2);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(105, 48);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(48, 70, 116);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(12, 209);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 48);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(12, 157);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(105, 48);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // lstProdutos
            // 
            lstProdutos.Location = new Point(153, 106);
            lstProdutos.Margin = new Padding(2);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(539, 211);
            lstProdutos.TabIndex = 17;
            lstProdutos.UseCompatibleStateImageBehavior = false;
            lstProdutos.View = View.Details;
            // 
            // cboxCategoria
            // 
            cboxCategoria.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Location = new Point(155, 352);
            cboxCategoria.Margin = new Padding(2);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(130, 27);
            cboxCategoria.TabIndex = 18;
            cboxCategoria.Text = "Categoria";
            cboxCategoria.SelectedIndexChanged += cboxCategoria_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(153, 319);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(339, 29);
            label3.TabIndex = 19;
            label3.Text = "Filtrar e Calcular por Categoria";
            // 
            // btnAtualizaLista
            // 
            btnAtualizaLista.BackColor = Color.FromArgb(48, 70, 116);
            btnAtualizaLista.FlatAppearance.BorderSize = 0;
            btnAtualizaLista.FlatStyle = FlatStyle.Flat;
            btnAtualizaLista.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizaLista.ForeColor = Color.White;
            btnAtualizaLista.Location = new Point(565, 75);
            btnAtualizaLista.Margin = new Padding(2);
            btnAtualizaLista.Name = "btnAtualizaLista";
            btnAtualizaLista.Size = new Size(127, 24);
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
            btnCalcular.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(290, 352);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 27);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtBoxResultado
            // 
            txtBoxResultado.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxResultado.Location = new Point(426, 352);
            txtBoxResultado.Name = "txtBoxResultado";
            txtBoxResultado.Size = new Size(130, 27);
            txtBoxResultado.TabIndex = 23;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(700, 390);
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
            Name = "Produtos";
            ShowInTaskbar = false;
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
        private PictureBox pictureBox1;
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
    }
}