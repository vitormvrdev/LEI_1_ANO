namespace _009___Projeto_Final
{
    partial class formEliminarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEliminarProduto));
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Button();
            label2 = new Label();
            btnBack = new Button();
            btnEliminarDados = new Button();
            cboxNomeEliminar = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(223, 33);
            label1.TabIndex = 3;
            label1.Text = "Remover Produto";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(733, 1);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(57, 67);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(202, 231);
            label2.Name = "label2";
            label2.Size = new Size(219, 33);
            label2.TabIndex = 11;
            label2.Text = "Nome a eliminar:";
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
            btnBack.TabIndex = 12;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEliminarDados
            // 
            btnEliminarDados.BackColor = Color.FromArgb(48, 70, 116);
            btnEliminarDados.FlatAppearance.BorderSize = 0;
            btnEliminarDados.FlatStyle = FlatStyle.Flat;
            btnEliminarDados.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarDados.ForeColor = Color.White;
            btnEliminarDados.Location = new Point(666, 437);
            btnEliminarDados.Margin = new Padding(3, 4, 3, 4);
            btnEliminarDados.Name = "btnEliminarDados";
            btnEliminarDados.Size = new Size(120, 67);
            btnEliminarDados.TabIndex = 13;
            btnEliminarDados.Text = "Eliminar";
            btnEliminarDados.UseVisualStyleBackColor = false;
            btnEliminarDados.Click += btnEliminarDados_Click;
            // 
            // cboxNomeEliminar
            // 
            cboxNomeEliminar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboxNomeEliminar.FormattingEnabled = true;
            cboxNomeEliminar.Location = new Point(407, 233);
            cboxNomeEliminar.Margin = new Padding(3, 4, 3, 4);
            cboxNomeEliminar.Name = "cboxNomeEliminar";
            cboxNomeEliminar.Size = new Size(172, 32);
            cboxNomeEliminar.TabIndex = 14;
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
            // formEliminarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(800, 520);
            ControlBox = false;
            Controls.Add(cboxNomeEliminar);
            Controls.Add(btnEliminarDados);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "formEliminarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveProduct";
            Load += RemoveProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private Button btnBack;
        private Button btnEliminarDados;
        private ComboBox cboxNomeEliminar;
        private PictureBox pictureBox1;
    }
}