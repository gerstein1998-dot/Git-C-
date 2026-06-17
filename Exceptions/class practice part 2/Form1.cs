namespace class_practice_part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


    


        public void btncalculator_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnumOfEmploees.Text == "" || txttotalBudget.Text == "")
                {
                    throw new FormatException("לא ניתן להשלים את חישוב התקציב בלי מילוי כל השדות הנתונים");
                }
                double budget = double.Parse(txttotalBudget.Text);
                int numEmploees = int.Parse(txtnumOfEmploees.Text);
                


                if (numEmploees == 0)
                {
                    throw new DivideByZeroException("לא ניתן לחלק את התקציב ל0 עובדים עליך להכניס מספר עובדים גדול מ0");
                }
                else if (numEmploees < 0)
                {
                    throw new FormatException("מספר העובדים לא יכול להיות שלילי");
                }

                double calc = (budget / numEmploees);
                lblres.Text = $"budget per emploee:{calc}";


            }

            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "שיגאה לוגית", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException dz)
            {
                MessageBox.Show(dz.Message, "שגיאה מתמטית", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txtnumOfEmploees.Clear();
                txttotalBudget.Clear();
            }
           
        }
    }
}
