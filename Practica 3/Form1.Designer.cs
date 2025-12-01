namespace Practica_3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            botonComenzar = new Button();
            Salir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botonComenzar
            // 
            botonComenzar.BackColor = Color.FromArgb(255, 192, 128);
            botonComenzar.Location = new Point(166, 248);
            botonComenzar.Name = "botonComenzar";
            botonComenzar.Size = new Size(112, 34);
            botonComenzar.TabIndex = 0;
            botonComenzar.Text = "Comenzar";
            botonComenzar.UseVisualStyleBackColor = false;
            botonComenzar.Click += botonComenzar_Click;
            // 
            // Salir
            // 
            Salir.BackColor = Color.FromArgb(255, 192, 128);
            Salir.Location = new Point(166, 333);
            Salir.Name = "Salir";
            Salir.Size = new Size(112, 34);
            Salir.TabIndex = 1;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(446, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 237);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(104, 157);
            label1.Name = "label1";
            label1.Size = new Size(261, 48);
            label1.TabIndex = 3;
            label1.Text = "Sensor Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 20);
            label2.Name = "label2";
            label2.Size = new Size(678, 65);
            label2.TabIndex = 4;
            label2.Text = "Sensor Lluvia FC-37 o YL-83";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Salir);
            Controls.Add(botonComenzar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonComenzar;
        private Button Salir;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
