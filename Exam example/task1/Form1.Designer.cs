namespace task1
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
            btnEnd = new Button();
            btnRoll = new Button();
            lblRandomNum = new Label();
            SuspendLayout();
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(117, 221);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(94, 29);
            btnEnd.TabIndex = 0;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(300, 221);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(94, 29);
            btnRoll.TabIndex = 1;
            btnRoll.Text = "Roll it!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblRandomNum
            // 
            lblRandomNum.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRandomNum.Location = new Point(199, 105);
            lblRandomNum.Name = "lblRandomNum";
            lblRandomNum.Size = new Size(123, 77);
            lblRandomNum.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 327);
            Controls.Add(lblRandomNum);
            Controls.Add(btnRoll);
            Controls.Add(btnEnd);
            Name = "Form1";
            Text = "Rolleta";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnd;
        private Button btnRoll;
        private Label lblRandomNum;
    }
}
