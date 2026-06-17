namespace class_practice_part_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCala_Click(object sender, EventArgs e)
        {
            try 
            {
                double precent = 0.1;
                
            if (txtSales.Text == "" || txtYears.Text == "")
                {
                    throw new FormatException("חייב למלא את השדות הנתונים במספר");
                }
                int years = int.Parse(txtYears.Text);
                int sales = int.Parse(txtSales.Text);
                if (years <= 0 || years > 40)
                {
                    throw new Exception("שנות וותק חייבות להיות בין 0-40");
                }
                if (sales <= 0 )
                {
                    throw new Exception("סך המכירות חייב להיות גדול מ0 ולא יכול להיות שלילי");
                }

                double bonuse = ((sales * precent) + (years * 500));
                lblBonus.Text = $"הבונוס החודשי שלך הוא: {bonuse} ";

            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "שגיאה לוגית", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                txtSales.Clear();
                txtYears.Clear();
            }
        }
        }
    }

