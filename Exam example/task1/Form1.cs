namespace task1
{
    public partial class Form1 : Form
    {
        int index; 
        int game;
        List<DateTimeIRN> game1List;
        List<DateTimeIRN> game2List;

        public Form1()
        {
            InitializeComponent();
            game1List = new List<DateTimeIRN>();
            game2List = new List<DateTimeIRN>();
            index = 1;
            game = 1;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (game == 1 && index <= 4)
            {
                    RollNewNumber();
                if (index == 4)
                {
                    index = 0;
                    game++;
                    
                }
                index++;
            }
            else if (game == 2 && index <= 5)
            {
                    RollNewNumber();
                if (index == 5)
                {
                    game++;
                    index = 0;
                }

                index++;

            }
            else if (game > 2)
            {
                Form2 form2 = new Form2(game1List,game2List);
                form2.Show();
            }
        }
        

        private void RollNewNumber()
        {
           
            DateTimeIRN dateTime = new DateTimeIRN(index);
            int num = dateTime.Number;
            if (num.ToString().Contains("7"))
            {
                lblRandomNum.Text = num.ToString();
                MessageBox.Show( "there is number seven :)", "GOOD LUCK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblRandomNum.Text = num.ToString();
            }
            if (game == 1)
            {
                game1List.Add(dateTime);
            }
            else if (game == 2)
            {
                game2List.Add(dateTime);
            }
           
        }
        

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(game1List,game2List);
            form2.Show();
        }
    }
}
