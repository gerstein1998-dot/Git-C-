using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace home_task_2_GUI
{
    public partial class AddForm : Form
    {
        Form1 form1;
        public AddForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            form1.Show();
            Close();

        }
    }
}
