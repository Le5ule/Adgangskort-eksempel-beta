namespace TestGUI
{
    partial class Terminal
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
            BTN0 = new Button();
            BTN9 = new Button();
            BTN8 = new Button();
            BTN7 = new Button();
            BTN6 = new Button();
            BTN5 = new Button();
            BTN4 = new Button();
            BTN3 = new Button();
            BTN2 = new Button();
            BTN1 = new Button();
            TB_KomboTerm = new TextBox();
            SuspendLayout();
            // 
            // BTN0
            // 
            BTN0.Location = new Point(66, 187);
            BTN0.Name = "BTN0";
            BTN0.Size = new Size(23, 25);
            BTN0.TabIndex = 24;
            BTN0.Text = "0";
            BTN0.UseVisualStyleBackColor = true;
            BTN0.Click += BTN0_Click;
            // 
            // BTN9
            // 
            BTN9.Location = new Point(93, 159);
            BTN9.Name = "BTN9";
            BTN9.Size = new Size(23, 25);
            BTN9.TabIndex = 23;
            BTN9.Text = "9";
            BTN9.UseVisualStyleBackColor = true;
            BTN9.Click += BTN9_Click;
            // 
            // BTN8
            // 
            BTN8.Location = new Point(66, 159);
            BTN8.Name = "BTN8";
            BTN8.Size = new Size(23, 25);
            BTN8.TabIndex = 22;
            BTN8.Text = "8";
            BTN8.UseVisualStyleBackColor = true;
            BTN8.Click += BTN8_Click;
            // 
            // BTN7
            // 
            BTN7.Location = new Point(39, 159);
            BTN7.Name = "BTN7";
            BTN7.Size = new Size(23, 25);
            BTN7.TabIndex = 21;
            BTN7.Text = "7";
            BTN7.UseVisualStyleBackColor = true;
            BTN7.Click += BTN7_Click;
            // 
            // BTN6
            // 
            BTN6.Location = new Point(93, 130);
            BTN6.Name = "BTN6";
            BTN6.Size = new Size(23, 25);
            BTN6.TabIndex = 20;
            BTN6.Text = "6";
            BTN6.UseVisualStyleBackColor = true;
            BTN6.Click += BTN6_Click;
            // 
            // BTN5
            // 
            BTN5.Location = new Point(66, 130);
            BTN5.Name = "BTN5";
            BTN5.Size = new Size(23, 25);
            BTN5.TabIndex = 19;
            BTN5.Text = "5";
            BTN5.UseVisualStyleBackColor = true;
            BTN5.Click += BTN5_Click;
            // 
            // BTN4
            // 
            BTN4.Location = new Point(39, 130);
            BTN4.Name = "BTN4";
            BTN4.Size = new Size(23, 25);
            BTN4.TabIndex = 18;
            BTN4.Text = "4";
            BTN4.UseVisualStyleBackColor = true;
            BTN4.Click += BTN4_Click;
            // 
            // BTN3
            // 
            BTN3.Location = new Point(93, 101);
            BTN3.Name = "BTN3";
            BTN3.Size = new Size(23, 25);
            BTN3.TabIndex = 17;
            BTN3.Text = "3";
            BTN3.UseVisualStyleBackColor = true;
            BTN3.Click += BTN3_Click;
            // 
            // BTN2
            // 
            BTN2.Location = new Point(66, 101);
            BTN2.Name = "BTN2";
            BTN2.Size = new Size(23, 25);
            BTN2.TabIndex = 16;
            BTN2.Text = "2";
            BTN2.UseVisualStyleBackColor = true;
            BTN2.Click += BTN2_Click;
            // 
            // BTN1
            // 
            BTN1.Location = new Point(39, 101);
            BTN1.Name = "BTN1";
            BTN1.Size = new Size(23, 25);
            BTN1.TabIndex = 15;
            BTN1.Text = "1";
            BTN1.UseVisualStyleBackColor = true;
            BTN1.Click += BTN1_Click;
            // 
            // TB_KomboTerm
            // 
            TB_KomboTerm.Location = new Point(39, 39);
            TB_KomboTerm.Name = "TB_KomboTerm";
            TB_KomboTerm.ReadOnly = true;
            TB_KomboTerm.Size = new Size(77, 27);
            TB_KomboTerm.TabIndex = 26;
            // 
            // Terminal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(158, 249);
            Controls.Add(TB_KomboTerm);
            Controls.Add(BTN0);
            Controls.Add(BTN9);
            Controls.Add(BTN8);
            Controls.Add(BTN7);
            Controls.Add(BTN6);
            Controls.Add(BTN5);
            Controls.Add(BTN4);
            Controls.Add(BTN3);
            Controls.Add(BTN2);
            Controls.Add(BTN1);
            Name = "Terminal";
            Text = "Terminal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN0;
        private Button BTN9;
        private Button BTN8;
        private Button BTN7;
        private Button BTN6;
        private Button BTN5;
        private Button BTN4;
        private Button BTN3;
        private Button BTN2;
        private Button BTN1;
        private TextBox TB_KomboTerm;
    }
}