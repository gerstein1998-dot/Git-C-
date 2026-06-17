namespace class_practice_part_2._2
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
            txtSales = new TextBox();
            txtYears = new TextBox();
            btnCala = new Button();
            lblBonus = new Label();
            SuspendLayout();
            // 
            // txtSales
            // 
            txtSales.Location = new Point(69, 59);
            txtSales.Name = "txtSales";
            txtSales.PlaceholderText = "Total sales";
            txtSales.Size = new Size(125, 27);
            txtSales.TabIndex = 0;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(69, 115);
            txtYears.Name = "txtYears";
            txtYears.PlaceholderText = "Years of seniority";
            txtYears.Size = new Size(125, 27);
            txtYears.TabIndex = 1;
            // 
            // btnCala
            // 
            btnCala.Location = new Point(69, 175);
            btnCala.Name = "btnCala";
            btnCala.Size = new Size(125, 30);
            btnCala.TabIndex = 2;
            btnCala.Text = "Calculat bonus";
            btnCala.UseVisualStyleBackColor = true;
            btnCala.Click += btnCala_Click;
            // 
            // lblBonus
            // 
            lblBonus.AutoSize = true;
            lblBonus.Location = new Point(105, 289);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(0, 20);
            lblBonus.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 534);
            Controls.Add(lblBonus);
            Controls.Add(btnCala);
            Controls.Add(txtYears);
            Controls.Add(txtSales);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSales;
        private TextBox txtYears;
        private Button btnCala;
        private Label lblBonus;
    }
}
