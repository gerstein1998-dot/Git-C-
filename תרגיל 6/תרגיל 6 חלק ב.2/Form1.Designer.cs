namespace תרגיל_6_חלק_ב._2
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
            dgvItem = new DataGridView();
            gbDelete = new GroupBox();
            txtCode = new TextBox();
            btnDelete = new Button();
            gbInsert = new GroupBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            btnInsert = new Button();
            btnUpdateDB = new Button();
            txtFilter = new TextBox();
            btnFilter = new Button();
            btnCancelF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            gbDelete.SuspendLayout();
            gbInsert.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItem
            // 
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Location = new Point(12, 31);
            dgvItem.Name = "dgvItem";
            dgvItem.RowHeadersWidth = 51;
            dgvItem.Size = new Size(560, 210);
            dgvItem.TabIndex = 0;
            // 
            // gbDelete
            // 
            gbDelete.Controls.Add(txtCode);
            gbDelete.Controls.Add(btnDelete);
            gbDelete.Location = new Point(23, 272);
            gbDelete.Name = "gbDelete";
            gbDelete.Size = new Size(327, 162);
            gbDelete.TabIndex = 1;
            gbDelete.TabStop = false;
            gbDelete.Text = "Delete item";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(104, 60);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(120, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbInsert
            // 
            gbInsert.Controls.Add(txtPrice);
            gbInsert.Controls.Add(txtDescription);
            gbInsert.Controls.Add(txtName);
            gbInsert.Controls.Add(btnInsert);
            gbInsert.Location = new Point(428, 272);
            gbInsert.Name = "gbInsert";
            gbInsert.Size = new Size(494, 162);
            gbInsert.TabIndex = 2;
            gbInsert.TabStop = false;
            gbInsert.Text = "Insert";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(351, 60);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(206, 60);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(159, 104);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(213, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(657, 167);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(177, 74);
            btnUpdateDB.TabIndex = 3;
            btnUpdateDB.Text = "Update data base";
            btnUpdateDB.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(609, 31);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Above the price for filtering";
            txtFilter.Size = new Size(271, 27);
            txtFilter.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(609, 76);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCancelF
            // 
            btnCancelF.Location = new Point(761, 76);
            btnCancelF.Name = "btnCancelF";
            btnCancelF.Size = new Size(161, 29);
            btnCancelF.TabIndex = 6;
            btnCancelF.Text = "Cancel filter";
            btnCancelF.UseVisualStyleBackColor = true;
            btnCancelF.Click += btnCancelF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 469);
            Controls.Add(btnCancelF);
            Controls.Add(btnFilter);
            Controls.Add(txtFilter);
            Controls.Add(btnUpdateDB);
            Controls.Add(gbInsert);
            Controls.Add(gbDelete);
            Controls.Add(dgvItem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            gbDelete.ResumeLayout(false);
            gbDelete.PerformLayout();
            gbInsert.ResumeLayout(false);
            gbInsert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItem;
        private GroupBox gbDelete;
        private TextBox txtCode;
        private Button btnDelete;
        private GroupBox gbInsert;
        private Button btnInsert;
        private Button btnUpdateDB;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtFilter;
        private Button btnFilter;
        private Button btnCancelF;
    }
}
