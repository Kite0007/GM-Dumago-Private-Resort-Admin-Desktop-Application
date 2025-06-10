namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Loginbtn = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(60, 65, 70);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(619, 213);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(232, 25);
            textBox2.TabIndex = 37;
            textBox2.Text = "  Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(765, 350);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 36;
            label2.Text = "Login Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(619, 350);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 35;
            label1.Text = "Already have an account?";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.FromArgb(20, 200, 120);
            Loginbtn.FlatAppearance.BorderSize = 0;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.ForeColor = Color.White;
            Loginbtn.Location = new Point(619, 283);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(232, 37);
            Loginbtn.TabIndex = 34;
            Loginbtn.Text = "LOGIN";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(60, 65, 70);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(619, 170);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 33;
            textBox1.Text = "  Email@gmail.com";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(488, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 65, 70);
            ClientSize = new Size(1070, 533);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Loginbtn);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button Loginbtn;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
