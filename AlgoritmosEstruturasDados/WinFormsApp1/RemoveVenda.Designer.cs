namespace WinFormsApp1
{
    partial class RemoveVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveVenda));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            cboxNomeEliminarVenda = new ComboBox();
            label2 = new Label();
            btnEliminarDados = new Button();
            btnBack = new Button();
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
            label1.Size = new Size(160, 25);
            label1.TabIndex = 3;
            label1.Text = "Remover Venda";
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
            // cboxNomeEliminarVenda
            // 
            cboxNomeEliminarVenda.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxNomeEliminarVenda.FormattingEnabled = true;
            cboxNomeEliminarVenda.Location = new Point(360, 185);
            cboxNomeEliminarVenda.Name = "cboxNomeEliminarVenda";
            cboxNomeEliminarVenda.Size = new Size(151, 27);
            cboxNomeEliminarVenda.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(172, 187);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 15;
            label2.Text = "Código de Venda";
            // 
            // btnEliminarDados
            // 
            btnEliminarDados.BackColor = Color.FromArgb(48, 70, 116);
            btnEliminarDados.FlatAppearance.BorderSize = 0;
            btnEliminarDados.FlatStyle = FlatStyle.Flat;
            btnEliminarDados.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarDados.ForeColor = Color.White;
            btnEliminarDados.Location = new Point(583, 328);
            btnEliminarDados.Name = "btnEliminarDados";
            btnEliminarDados.Size = new Size(105, 50);
            btnEliminarDados.TabIndex = 18;
            btnEliminarDados.Text = "Eliminar";
            btnEliminarDados.UseVisualStyleBackColor = false;
            btnEliminarDados.Click += btnEliminarDados_Click;
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
            btnBack.TabIndex = 17;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // RemoveVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(700, 390);
            Controls.Add(btnEliminarDados);
            Controls.Add(btnBack);
            Controls.Add(cboxNomeEliminarVenda);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveVenda";
            Text = "RemoverVenda";
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
        private ComboBox cboxNomeEliminarVenda;
        private Label label2;
        private Button btnEliminarDados;
        private Button btnBack;
    }
}