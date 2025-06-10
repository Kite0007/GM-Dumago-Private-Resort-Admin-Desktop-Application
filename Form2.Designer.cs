namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(60, 65, 70);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(619, 244);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.Size = new Size(232, 25);
            textBox3.TabIndex = 46;
            textBox3.Text = "  Confirm Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(60, 65, 70);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(619, 203);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(232, 25);
            textBox2.TabIndex = 45;
            textBox2.Text = "  Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(765, 375);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 44;
            label2.Text = "Login Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(619, 375);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 43;
            label1.Text = "Already have an account?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 200, 120);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(619, 308);
            button2.Name = "button2";
            button2.Size = new Size(232, 37);
            button2.TabIndex = 42;
            button2.Text = "CREATE ACCOUNT";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(60, 65, 70);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(619, 160);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 41;
            textBox1.Text = "  Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(488, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 65, 70);
            ClientSize = new Size(1070, 533);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}