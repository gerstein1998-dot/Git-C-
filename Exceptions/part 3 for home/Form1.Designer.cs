namespace part_3_for_home
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
            txtItemName = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantityToAdd = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(52, 74);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "item name";
            txtItemName.Size = new Size(125, 27);
            txtItemName.TabIndex = 0;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(52, 137);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "unit price";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // txtQuantityToAdd
            // 
            txtQuantityToAdd.Location = new Point(52, 210);
            txtQuantityToAdd.Name = "txtQuantityToAdd";
            txtQuantityToAdd.PlaceholderText = "Quantity to add";
            txtQuantityToAdd.Size = new Size(125, 27);
            txtQuantityToAdd.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(52, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 33);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add to stock";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 595);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantityToAdd);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtItemName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItemName;
        private TextBox txtUnitPrice;
        private TextBox txtQuantityToAdd;
        private Button btnAdd;
    }
}
