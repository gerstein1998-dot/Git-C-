namespace part_3_for_home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text == "" || txtUnitPrice.Text == "" || txtQuantityToAdd.Text == "")
                {
                    throw new FormatException("עליך למלא את כל השדות הנתונים");
                }
                string itemName = txtItemName.Text;
                double price = double.Parse(txtUnitPrice.Text);
                int quantity = int.Parse(txtQuantityToAdd.Text);
                
                if (quantity <= 0)
                {
                    throw new Exception("כמות חייבת להיות מספר שלם וחיובי");
                }

                if (price <= 0) 
                {
                    throw new Exception("מחיר חייבת להיות מעל 0. דמי הניהול המינימלים לא מאפשרים קליטת פריטים בחינם");
                }


                MessageBox.Show(@$"The item {itemName} was successfully receivd."+ "\n" +
                    $"added inventory value: {price * quantity}");


            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message,"שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "לוגיקה עסקית", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtItemName.Clear();
                txtQuantityToAdd.Clear();
                txtUnitPrice.Clear();
            }
        }
    }
}


