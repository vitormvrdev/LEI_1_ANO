namespace WinFormsApp1
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 70, 116);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 50);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 15);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 3;
            label2.Text = "Inserir Produto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.open_box;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(3, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(641, 1);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
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
            btnSalvar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(583, 328);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 50);
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
            btnBack.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 328);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 50);
            btnBack.TabIndex = 9;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(48, 70, 116);
            label1.Location = new Point(182, 109);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 10;
            label1.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(182, 147);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F);
            label4.ForeColor = Color.FromArgb(48, 70, 116);
            label4.Location = new Point(182, 187);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 12;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F);
            label5.ForeColor = Color.FromArgb(48, 70, 116);
            label5.Location = new Point(182, 224);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 13;
            label5.Text = "Preço";
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Font = new Font("Tahoma", 12F);
            txtBoxCodigo.Location = new Point(305, 115);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(204, 27);
            txtBoxCodigo.TabIndex = 14;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Font = new Font("Tahoma", 12F);
            txtBoxNome.Location = new Point(305, 153);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(204, 27);
            txtBoxNome.TabIndex = 15;
            // 
            // txtBoxCategoria
            // 
            txtBoxCategoria.Font = new Font("Tahoma", 12F);
            txtBoxCategoria.Location = new Point(305, 193);
            txtBoxCategoria.Name = "txtBoxCategoria";
            txtBoxCategoria.Size = new Size(204, 27);
            txtBoxCategoria.TabIndex = 16;
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.Font = new Font("Tahoma", 12F);
            txtBoxPreco.Location = new Point(305, 230);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(204, 27);
            txtBoxPreco.TabIndex = 17;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 232);
            ClientSize = new Size(700, 390);
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
            Margin = new Padding(2);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
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
    }
}