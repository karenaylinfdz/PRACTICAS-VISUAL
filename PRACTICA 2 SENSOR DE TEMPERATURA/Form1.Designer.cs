namespace PRACTICA_2_SENSOR_DE_TEMPERATURA
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
            listBox1 = new ListBox();
            botonConectar = new Button();
            button1_Click_1 = new Button();
            LABEL1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 192, 255);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(479, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(569, 454);
            listBox1.TabIndex = 0;
            // 
            // botonConectar
            // 
            botonConectar.BackColor = Color.FromArgb(64, 0, 64);
            botonConectar.ForeColor = SystemColors.ButtonHighlight;
            botonConectar.Location = new Point(45, 498);
            botonConectar.Name = "botonConectar";
            botonConectar.Size = new Size(204, 60);
            botonConectar.TabIndex = 1;
            botonConectar.Text = "CONECTAR";
            botonConectar.UseVisualStyleBackColor = false;
            botonConectar.Click += button1_Click;
            // 
            // button1_Click_1
            // 
            button1_Click_1.BackColor = Color.FromArgb(64, 0, 64);
            button1_Click_1.ForeColor = SystemColors.ButtonHighlight;
            button1_Click_1.Location = new Point(882, 505);
            button1_Click_1.Name = "button1_Click_1";
            button1_Click_1.Size = new Size(146, 47);
            button1_Click_1.TabIndex = 2;
            button1_Click_1.Text = "SALIR";
            button1_Click_1.UseVisualStyleBackColor = false;
            button1_Click_1.Click += button1_Click_1_Click;
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL1.Location = new Point(23, 215);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(252, 45);
            LABEL1.TabIndex = 3;
            LABEL1.Text = "TEMPERATURA";
            LABEL1.Click += LABEL1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 450);
            label2.Name = "label2";
            label2.Size = new Size(196, 45);
            label2.TabIndex = 4;
            label2.Text = "HUMEDAD ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(32, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 200);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hum;
            pictureBox2.Location = new Point(32, 263);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 184);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(1060, 570);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(LABEL1);
            Controls.Add(button1_Click_1);
            Controls.Add(botonConectar);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button botonConectar;
        private Button button1_Click_1;
        private Label LABEL1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
