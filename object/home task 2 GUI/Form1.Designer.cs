namespace home_task_2_GUI
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
            menuStrip1 = new MenuStrip();
            tsViewSystem = new ToolStripMenuItem();
            tsAddAnimal = new ToolStripMenuItem();
            viewSystemToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsViewSystem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsViewSystem
            // 
            tsViewSystem.DropDownItems.AddRange(new ToolStripItem[] { tsAddAnimal, viewSystemToolStripMenuItem });
            tsViewSystem.Name = "tsViewSystem";
            tsViewSystem.Size = new Size(94, 24);
            tsViewSystem.Text = "operations";
            // 
            // tsAddAnimal
            // 
            tsAddAnimal.Name = "tsAddAnimal";
            tsAddAnimal.Size = new Size(224, 26);
            tsAddAnimal.Text = "add animal";
            tsAddAnimal.Click += tsAddAnimal_Click;
            // 
            // viewSystemToolStripMenuItem
            // 
            viewSystemToolStripMenuItem.Name = "viewSystemToolStripMenuItem";
            viewSystemToolStripMenuItem.Size = new Size(224, 26);
            viewSystemToolStripMenuItem.Text = "view system";
            viewSystemToolStripMenuItem.Click += viewSystemToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsViewSystem;
        private ToolStripMenuItem tsAddAnimal;
        private ToolStripMenuItem viewSystemToolStripMenuItem;
    }
}
