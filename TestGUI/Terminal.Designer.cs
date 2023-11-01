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
            BTN_Kort = new Button();
            UgyldigLabel = new Label();
            TB_KortInput = new TextBox();
            SuspendLayout();
            // 
            // BTN0
            // 
            BTN0.Location = new Point(53, 229);
            BTN0.Name = "BTN0";
            BTN0.Size = new Size(23, 25);
            BTN0.TabIndex = 24;
            BTN0.Text = "0";
            BTN0.UseVisualStyleBackColor = true;
            BTN0.Click += BTN0_Click;
            // 
            // BTN9
            // 
            BTN9.Location = new Point(80, 201);
            BTN9.Name = "BTN9";
            BTN9.Size = new Size(23, 25);
            BTN9.TabIndex = 23;
            BTN9.Text = "9";
            BTN9.UseVisualStyleBackColor = true;
            BTN9.Click += BTN9_Click;
            // 
            // BTN8
            // 
            BTN8.Location = new Point(53, 201);
            BTN8.Name = "BTN8";
            BTN8.Size = new Size(23, 25);
            BTN8.TabIndex = 22;
            BTN8.Text = "8";
            BTN8.UseVisualStyleBackColor = true;
            BTN8.Click += BTN8_Click;
            // 
            // BTN7
            // 
            BTN7.Location = new Point(26, 201);
            BTN7.Name = "BTN7";
            BTN7.Size = new Size(23, 25);
            BTN7.TabIndex = 21;
            BTN7.Text = "7";
            BTN7.UseVisualStyleBackColor = true;
            BTN7.Click += BTN7_Click;
            // 
            // BTN6
            // 
            BTN6.Location = new Point(80, 172);
            BTN6.Name = "BTN6";
            BTN6.Size = new Size(23, 25);
            BTN6.TabIndex = 20;
            BTN6.Text = "6";
            BTN6.UseVisualStyleBackColor = true;
            BTN6.Click += BTN6_Click;
            // 
            // BTN5
            // 
            BTN5.Location = new Point(53, 172);
            BTN5.Name = "BTN5";
            BTN5.Size = new Size(23, 25);
            BTN5.TabIndex = 19;
            BTN5.Text = "5";
            BTN5.UseVisualStyleBackColor = true;
            BTN5.Click += BTN5_Click;
            // 
            // BTN4
            // 
            BTN4.Location = new Point(26, 172);
            BTN4.Name = "BTN4";
            BTN4.Size = new Size(23, 25);
            BTN4.TabIndex = 18;
            BTN4.Text = "4";
            BTN4.UseVisualStyleBackColor = true;
            BTN4.Click += BTN4_Click;
            // 
            // BTN3
            // 
            BTN3.Location = new Point(80, 143);
            BTN3.Name = "BTN3";
            BTN3.Size = new Size(23, 25);
            BTN3.TabIndex = 17;
            BTN3.Text = "3";
            BTN3.UseVisualStyleBackColor = true;
            BTN3.Click += BTN3_Click;
            // 
            // BTN2
            // 
            BTN2.Location = new Point(53, 143);
            BTN2.Name = "BTN2";
            BTN2.Size = new Size(23, 25);
            BTN2.TabIndex = 16;
            BTN2.Text = "2";
            BTN2.UseVisualStyleBackColor = true;
            BTN2.Click += BTN2_Click;
            // 
            // BTN1
            // 
            BTN1.Location = new Point(26, 143);
            BTN1.Name = "BTN1";
            BTN1.Size = new Size(23, 25);
            BTN1.TabIndex = 15;
            BTN1.Text = "1";
            BTN1.UseVisualStyleBackColor = true;
            BTN1.Click += BTN1_Click;
            // 
            // TB_KomboTerm
            // 
            TB_KomboTerm.Location = new Point(152, 61);
            TB_KomboTerm.Name = "TB_KomboTerm";
            TB_KomboTerm.Size = new Size(77, 27);
            TB_KomboTerm.TabIndex = 26;
            // 
            // BTN_Kort
            // 
            BTN_Kort.Location = new Point(26, 70);
            BTN_Kort.Name = "BTN_Kort";
            BTN_Kort.Size = new Size(77, 34);
            BTN_Kort.TabIndex = 27;
            BTN_Kort.Text = "Les kort";
            BTN_Kort.UseVisualStyleBackColor = true;
            BTN_Kort.Click += BTN_Kort_Click;
            // 
            // UgyldigLabel
            // 
            UgyldigLabel.AutoSize = true;
            UgyldigLabel.Location = new Point(17, 17);
            UgyldigLabel.Name = "UgyldigLabel";
            UgyldigLabel.Size = new Size(102, 40);
            UgyldigLabel.TabIndex = 28;
            UgyldigLabel.Text = "Ugyldig input,\r\nprøv igjen";
            UgyldigLabel.Visible = false;
            // 
            // TB_KortInput
            // 
            TB_KortInput.AcceptsReturn = true;
            TB_KortInput.Location = new Point(26, 110);
            TB_KortInput.Name = "TB_KortInput";
            TB_KortInput.Size = new Size(77, 27);
            TB_KortInput.TabIndex = 29;
            TB_KortInput.Visible = false;
            // 
            // Terminal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 295);
            Controls.Add(TB_KortInput);
            Controls.Add(UgyldigLabel);
            Controls.Add(BTN_Kort);
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
            Load += Terminal_Load;
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
        private Button BTN_Kort;
        private Label UgyldigLabel;
        private TextBox TB_KortInput;
    }
}