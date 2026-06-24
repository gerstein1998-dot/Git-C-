namespace home_task_2__6._2_
{
    public partial class Form1 : Form
    {
        Store s = new Store();
        public Form1()
        {
            InitializeComponent();
            dgvItem.DataSource = s.ItemTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Item item = new Item(txtName.Text, int.Parse(txtPrice.Text), txtDesc.Text);
            dgvItem.DataSource = s.InsertItem(item);

            txtName.Clear();
            txtPrice.Clear();
            txtDesc.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = s.DeleteItem(int.Parse(txtCode.Text));
            txtCode.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = s.FilterByAbovePrice(int.Parse(txtPrice.Text));
        }

        private void btnCancelF_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = s.ItemTable();
        }

     
    }
}


