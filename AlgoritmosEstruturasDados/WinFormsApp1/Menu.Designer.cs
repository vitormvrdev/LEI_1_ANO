namespace WinFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel2 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            goToVendedores = new Button();
            goToVendas = new Button();
            goToAnalises = new Button();
            goToProdutos = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 70, 116);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 83);
            panel2.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(803, 10);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(109, 62);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(272, 39);
            label2.TabIndex = 3;
            label2.Text = "Gestão de Vendas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.open_box;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(4, 10);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 67);
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
            button1.Location = new Point(916, 2);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(71, 83);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 116);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 567);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 217);
            label3.Name = "label3";
            label3.Size = new Size(241, 48);
            label3.TabIndex = 1;
            label3.Text = "Bem-Vindo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 28);
            label1.Name = "label1";
            label1.Size = new Size(159, 58);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // goToVendedores
            // 
            goToVendedores.BackColor = Color.FromArgb(48, 70, 116);
            goToVendedores.FlatAppearance.BorderSize = 0;
            goToVendedores.FlatStyle = FlatStyle.Flat;
            goToVendedores.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToVendedores.ForeColor = Color.White;
            goToVendedores.Location = new Point(421, 158);
            goToVendedores.Margin = new Padding(0);
            goToVendedores.Name = "goToVendedores";
            goToVendedores.Size = new Size(174, 100);
            goToVendedores.TabIndex = 4;
            goToVendedores.Text = "Vendedores";
            goToVendedores.UseVisualStyleBackColor = false;
            goToVendedores.Click += goToVendedores_Click;
            // 
            // goToVendas
            // 
            goToVendas.BackColor = Color.FromArgb(48, 70, 116);
            goToVendas.FlatAppearance.BorderSize = 0;
            goToVendas.FlatStyle = FlatStyle.Flat;
            goToVendas.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToVendas.ForeColor = Color.White;
            goToVendas.Location = new Point(421, 472);
            goToVendas.Margin = new Padding(0);
            goToVendas.Name = "goToVendas";
            goToVendas.Size = new Size(174, 100);
            goToVendas.TabIndex = 5;
            goToVendas.Text = "Vendas";
            goToVendas.UseVisualStyleBackColor = false;
            goToVendas.Click += goToVendas_Click;
            // 
            // goToAnalises
            // 
            goToAnalises.BackColor = Color.FromArgb(48, 70, 116);
            goToAnalises.FlatAppearance.BorderSize = 0;
            goToAnalises.FlatStyle = FlatStyle.Flat;
            goToAnalises.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToAnalises.ForeColor = Color.White;
            goToAnalises.Location = new Point(737, 472);
            goToAnalises.Margin = new Padding(0);
            goToAnalises.Name = "goToAnalises";
            goToAnalises.Size = new Size(174, 100);
            goToAnalises.TabIndex = 6;
            goToAnalises.Text = "Analises";
            goToAnalises.UseVisualStyleBackColor = false;
            goToAnalises.Click += goToAnalises_Click;
            // 
            // goToProdutos
            // 
            goToProdutos.BackColor = Color.FromArgb(48, 70, 116);
            goToProdutos.FlatAppearance.BorderSize = 0;
            goToProdutos.FlatStyle = FlatStyle.Flat;
            goToProdutos.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToProdutos.ForeColor = Color.White;
            goToProdutos.Location = new Point(737, 158);
            goToProdutos.Margin = new Padding(0);
            goToProdutos.Name = "goToProdutos";
            goToProdutos.Size = new Size(174, 100);
            goToProdutos.TabIndex = 7;
            goToProdutos.Text = "Produtos";
            goToProdutos.UseVisualStyleBackColor = false;
            goToProdutos.Click += goToProdutos_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(1000, 650);
            ControlBox = false;
            Controls.Add(goToProdutos);
            Controls.Add(goToVendedores);
            Controls.Add(goToVendas);
            Controls.Add(goToAnalises);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel panel1;
        private Button btnLogout;
        private Label label3;
        private Label label1;
        private Button goToVendedores;
        private Button goToVendas;
        private Button goToAnalises;
        private Button goToProdutos;
    }
}