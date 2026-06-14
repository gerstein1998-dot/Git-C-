namespace תרגיל_6_חלק_ב._2
{
    public partial class Form1 : Form
    {
        Store s = new Store();
        public Form1()
        {
            InitializeComponent();
            dgvItem.DataSource = s.ItemsTable(); //הצגה של הטבלה בקובץ
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Item item = new Item(txtName.Text, txtDescription.Text, int.Parse(txtPrice.Text));
            dgvItem.DataSource = s.InsertItem(item);
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = s.DeleteItem(int.Parse(txtCode.Text));
            txtCode.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = s.FilterByAbovePrice(int.Parse(txtFilter.Text));
        }

        private void btnCancelF_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = s.ItemsTable();
        }
    }
}
