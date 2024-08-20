namespace WinFormsApp1
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            lstVendas = new ListView();
            label2 = new Label();
            btnBack = new Button();
            btnInserir = new Button();
            btnRemover = new Button();
            btnAlterar = new Button();
            btnAtualizaListaVenda = new Button();
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
            panel1.Size = new Size(850, 50);
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
            btnExit.Click += btnExit_Click;
            // 
            // lstVendas
            // 
            lstVendas.Location = new Point(11, 104);
            lstVendas.Name = "lstVendas";
            lstVendas.Size = new Size(827, 503);
            lstVendas.TabIndex = 7;
            lstVendas.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(181, 29);
            label2.TabIndex = 6;
            label2.Text = "Lista de Vendas";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(48, 70, 116);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(11, 613);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 75);
            btnBack.TabIndex = 8;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(48, 70, 116);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(347, 613);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(150, 75);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(48, 70, 116);
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(519, 613);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(150, 75);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Eliminar";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(688, 613);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(150, 75);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnAtualizaListaVenda
            // 
            btnAtualizaListaVenda.BackColor = Color.FromArgb(48, 70, 116);
            btnAtualizaListaVenda.FlatAppearance.BorderSize = 0;
            btnAtualizaListaVenda.FlatStyle = FlatStyle.Flat;
            btnAtualizaListaVenda.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizaListaVenda.ForeColor = Color.White;
            btnAtualizaListaVenda.Location = new Point(711, 72);
            btnAtualizaListaVenda.Margin = new Padding(2);
            btnAtualizaListaVenda.Name = "btnAtualizaListaVenda";
            btnAtualizaListaVenda.Size = new Size(127, 24);
            btnAtualizaListaVenda.TabIndex = 22;
            btnAtualizaListaVenda.Text = "Atualizar Lista";
            btnAtualizaListaVenda.UseVisualStyleBackColor = false;
            btnAtualizaListaVenda.Click += btnAtualizaListaVenda_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(850, 700);
            ControlBox = false;
            Controls.Add(btnAtualizaListaVenda);
            Controls.Add(btnAlterar);
            Controls.Add(btnRemover);
            Controls.Add(btnInserir);
            Controls.Add(btnBack);
            Controls.Add(lstVendas);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vendas";
            Text = "Form1";
            Load += Vendas_Load;
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
        private ListView lstVendas;
        private Label label2;
        private Button btnBack;
        private Button btnInserir;
        private Button btnRemover;
        private Button btnAlterar;
        private Button btnAtualizaListaVenda;
    }
}
