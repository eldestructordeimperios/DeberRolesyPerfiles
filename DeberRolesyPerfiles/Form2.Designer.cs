namespace DeberRolesyPerfiles
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
            tsmenu = new ToolStrip();
            SuspendLayout();
            // 
            // tsmenu
            // 
            tsmenu.ImageScalingSize = new Size(20, 20);
            tsmenu.Location = new Point(0, 0);
            tsmenu.Name = "tsmenu";
            tsmenu.Size = new Size(800, 25);
            tsmenu.TabIndex = 1;
            tsmenu.Text = "tsMenu";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tsmenu);
            IsMdiContainer = true;
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsmenu;
    }
}