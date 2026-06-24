namespace home_task_2__6._2_
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
            btnCancelF = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            btnUpdateDB = new Button();
            btnFilter = new Button();
            groupBox1 = new GroupBox();
            txtCode = new TextBox();
            groupBox2 = new GroupBox();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtPruceFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItem
            // 
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Location = new Point(23, 35);
            dgvItem.Name = "dgvItem";
            dgvItem.RowHeadersWidth = 51;
            dgvItem.Size = new Size(887, 339);
            dgvItem.TabIndex = 0;
            // 
            // btnCancelF
            // 
            btnCancelF.Location = new Point(1001, 135);
            btnCancelF.Name = "btnCancelF";
            btnCancelF.Size = new Size(94, 59);
            btnCancelF.TabIndex = 1;
            btnCancelF.Text = "Cancel filter";
            btnCancelF.UseVisualStyleBackColor = true;
            btnCancelF.Click += btnCancelF_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(181, 117);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(344, 106);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(1061, 266);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(159, 78);
            btnUpdateDB.TabIndex = 4;
            btnUpdateDB.Text = "Update Data Base";
            btnUpdateDB.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(1191, 135);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 59);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(23, 429);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 156);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delete item";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(166, 62);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDesc);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Location = new Point(577, 429);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 156);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert item";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(583, 62);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Description";
            txtDesc.Size = new Size(125, 27);
            txtDesc.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(327, 62);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 62);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 10;
            // 
            // txtPruceFilter
            // 
            txtPruceFilter.Location = new Point(1030, 78);
            txtPruceFilter.Name = "txtPruceFilter";
            txtPruceFilter.PlaceholderText = "Above the price for filter";
            txtPruceFilter.Size = new Size(219, 27);
            txtPruceFilter.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 624);
            Controls.Add(txtPruceFilter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnFilter);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnCancelF);
            Controls.Add(dgvItem);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItem;
        private Button btnCancelF;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnUpdateDB;
        private Button btnFilter;
        private GroupBox groupBox1;
        private TextBox txtPruceFilter;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtCode;
        private GroupBox groupBox2;
        private TextBox txtDesc;
    }
}
