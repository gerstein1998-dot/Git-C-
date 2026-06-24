using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace task1
{
    public partial class Form2 : Form
    {
        public List<DateTimeIRN> game1List;
        public List<DateTimeIRN> game2List;
        string res;
        GameManager gm;
        int game;
       public DateTimeIRN maxNum;

        public Form2(List<DateTimeIRN> list1, List<DateTimeIRN> list2)
        {
            InitializeComponent();
            this.game1List = list1;
            this.game2List = list2;
            res = "";
            game = 0;
           gm= new GameManager();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PrintAllRes(game1List);
            lblResGame.Text = res;


            PrintAllRes(game2List);
            lblResGame.Text = res;


        }

        private void PrintAllRes(List<DateTimeIRN> gameNum)
        {
            maxNum = gameNum[0];
            foreach (DateTimeIRN n in gameNum)
            {
                if (gameNum == game1List)
                {
                    game = 1;
                    gm.AddNumToTBNum(game, n);
                }
                else
                {
                    game = 2;
                    gm.AddNumToTBNum(game, n);
                }
               

                if (n.Number > maxNum.Number)
                {
                    maxNum = n;
                    if (gameNum == game1List)
                    {
                        game = 1;
                        gm.AddNumToTBNum(game, n);
                    }
                    else
                    {
                        game = 2;
                        gm.AddNumToTBNum(game, n);
                    }
                }
            }
            foreach (DateTimeIRN n in gameNum)
            {
                if (n == maxNum)
                {
                    res += ("THE BIGGEST!!  " + n.ToString() + "\n");
                }
                else
                {
                    res += (n.ToString() + "\n");
                }
            }
            res += "\n";

        }
    }
}
