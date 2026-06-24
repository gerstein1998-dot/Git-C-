namespace home_task_2_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsAddAnimal_Click(object sender, EventArgs e)
        {
            AddForm addF = new AddForm(this);
            addF.Show();
            this.Hide();
        }

        private void viewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm viewF = new ViewForm();
            viewF.MdiParent = this;
            viewF.Show();
        }
    }
}
