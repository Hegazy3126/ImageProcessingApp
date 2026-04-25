namespace ImageProcessingApp
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
            panel1 = new Panel();
            btnReset = new Button();
            btnEdge = new Button();
            btnBlur = new Button();
            btnBrightMinus = new Button();
            btnBrightPlus = new Button();
            btnNegative = new Button();
            btnGray = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnEdge);
            panel1.Controls.Add(btnBlur);
            panel1.Controls.Add(btnBrightMinus);
            panel1.Controls.Add(btnBrightPlus);
            panel1.Controls.Add(btnNegative);
            panel1.Controls.Add(btnGray);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnOpen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 80);
            panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(808, 14);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnEdge
            // 
            btnEdge.Location = new Point(708, 14);
            btnEdge.Name = "btnEdge";
            btnEdge.Size = new Size(94, 29);
            btnEdge.TabIndex = 7;
            btnEdge.Text = "Edge";
            btnEdge.UseVisualStyleBackColor = true;
            btnEdge.Click += btnEdge_Click;
            // 
            // btnBlur
            // 
            btnBlur.Location = new Point(619, 14);
            btnBlur.Name = "btnBlur";
            btnBlur.Size = new Size(94, 29);
            btnBlur.TabIndex = 6;
            btnBlur.Text = "Blur";
            btnBlur.UseVisualStyleBackColor = true;
            btnBlur.Click += btnBlur_Click;
            // 
            // btnBrightMinus
            // 
            btnBrightMinus.Location = new Point(508, 14);
            btnBrightMinus.Name = "btnBrightMinus";
            btnBrightMinus.Size = new Size(94, 29);
            btnBrightMinus.TabIndex = 5;
            btnBrightMinus.Text = "Bright-";
            btnBrightMinus.UseVisualStyleBackColor = true;
            btnBrightMinus.Click += btnBrightMinus_Click;
            // 
            // btnBrightPlus
            // 
            btnBrightPlus.Location = new Point(408, 12);
            btnBrightPlus.Name = "btnBrightPlus";
            btnBrightPlus.Size = new Size(94, 29);
            btnBrightPlus.TabIndex = 4;
            btnBrightPlus.Text = "Bright+";
            btnBrightPlus.UseVisualStyleBackColor = true;
            btnBrightPlus.Click += btnBrightPlus_Click;
            // 
            // btnNegative
            // 
            btnNegative.Location = new Point(308, 12);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(94, 29);
            btnNegative.TabIndex = 3;
            btnNegative.Text = "Negative";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += button7_Click;
            // 
            // btnGray
            // 
            btnGray.Location = new Point(208, 12);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(94, 29);
            btnGray.TabIndex = 2;
            btnGray.Text = "Gray";
            btnGray.UseVisualStyleBackColor = true;
            btnGray.Click += btnGray_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(108, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnReset;
        private Button btnEdge;
        private Button btnBlur;
        private Button btnBrightMinus;
        private Button btnBrightPlus;
        private Button btnNegative;
        private Button btnGray;
        private Button btnSave;
        private Button btnOpen;
    }
}
