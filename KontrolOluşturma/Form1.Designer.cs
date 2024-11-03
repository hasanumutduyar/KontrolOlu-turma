namespace KontrolOluşturma
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
            btkbuton1 = new Btkbuton();
            btkbuton2 = new Btkbuton();
            btkSwitchButon1 = new BtkSwitchButon();
            SuspendLayout();
            // 
            // btkbuton1
            // 
            btkbuton1.BackColor = Color.BlueViolet;
            btkbuton1.ForeColor = Color.White;
            btkbuton1.Location = new Point(-2, 12);
            btkbuton1.Name = "btkbuton1";
            btkbuton1.Size = new Size(122, 52);
            btkbuton1.TabIndex = 0;
            btkbuton1.Text = "btkbuton1";
            btkbuton1.UseVisualStyleBackColor = false;
            // 
            // btkbuton2
            // 
            btkbuton2.BackColor = Color.BlueViolet;
            btkbuton2.ForeColor = Color.White;
            btkbuton2.Location = new Point(151, 12);
            btkbuton2.Name = "btkbuton2";
            btkbuton2.Size = new Size(122, 52);
            btkbuton2.TabIndex = 1;
            btkbuton2.Text = "btkbuton2";
            btkbuton2.UseVisualStyleBackColor = false;
            // 
            // btkSwitchButon1
            // 
            btkSwitchButon1.Location = new Point(48, 144);
            btkSwitchButon1.Name = "btkSwitchButon1";
            btkSwitchButon1.Size = new Size(103, 48);
            btkSwitchButon1.TabIndex = 2;
            btkSwitchButon1.Text = "btkSwitchButon1";
            btkSwitchButon1.Click += btkSwitchButon1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(btkSwitchButon1);
            Controls.Add(btkbuton2);
            Controls.Add(btkbuton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Btkbuton btkbuton1;
        private Btkbuton btkbuton2;
        private BtkSwitchButon btkSwitchButon1;
    }
}
