namespace class_practice_part_2
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
            txttotalBudget = new TextBox();
            txtnumOfEmploees = new TextBox();
            lblres = new Label();
            btncalculator = new Button();
            SuspendLayout();
            // 
            // txttotalBudget
            // 
            txttotalBudget.Location = new Point(70, 64);
            txttotalBudget.Name = "txttotalBudget";
            txttotalBudget.PlaceholderText = "total budget";
            txttotalBudget.Size = new Size(125, 27);
            txttotalBudget.TabIndex = 0;
            // 
            // txtnumOfEmploees
            // 
            txtnumOfEmploees.Location = new Point(70, 110);
            txtnumOfEmploees.Name = "txtnumOfEmploees";
            txtnumOfEmploees.PlaceholderText = "number of emploeees";
            txtnumOfEmploees.Size = new Size(239, 27);
            txtnumOfEmploees.TabIndex = 1;
            // 
            // lblres
            // 
            lblres.AutoSize = true;
            lblres.Location = new Point(70, 339);
            lblres.Name = "lblres";
            lblres.Size = new Size(0, 20);
            lblres.TabIndex = 2;
            // 
            // btncalculator
            // 
            btncalculator.Location = new Point(70, 159);
            btncalculator.Name = "btncalculator";
            btncalculator.Size = new Size(138, 63);
            btncalculator.TabIndex = 3;
            btncalculator.Text = "calculat budget to emploee";
            btncalculator.UseVisualStyleBackColor = true;
            btncalculator.Click += btncalculator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 587);
            Controls.Add(btncalculator);
            Controls.Add(lblres);
            Controls.Add(txtnumOfEmploees);
            Controls.Add(txttotalBudget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttotalBudget;
        private TextBox txtnumOfEmploees;
        private Label lblres;
        private Button btncalculator;
    }
}
