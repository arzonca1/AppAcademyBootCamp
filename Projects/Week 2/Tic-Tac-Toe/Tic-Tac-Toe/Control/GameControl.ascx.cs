using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tic_Tac_Toe.Control
{
    public partial class GameControl : System.Web.UI.UserControl
    {
        protected static bool GameInProgress = false;
        protected static bool AgainstAI;
        protected static string[,] Board;
        protected volatile static bool P2Turn = false;
        protected static Button[,] ButtonArray;
        protected static int Turn;



        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonArray = new Button[,]
            {
                {Button1, Button2, Button3 },
                {Button4, Button5, Button6 },
                {Button7, Button8, Button9 },
            };
        }

        private void clearBoard()
        {
            Turn = 0;

            //ButtonArray = new Button[,]
            //{
            //    {Button1, Button2, Button3 },
            //    {Button4, Button5, Button6 },
            //    {Button7, Button8, Button9 },
            //};
            Board = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ButtonArray[i, j].Text = " ";
                    Board[i, j] = " ";
                }
            }
        }

        protected void AIgame_Click(object sender, EventArgs e)
        {
            GameInProgress = true;
            AgainstAI = true;
            clearBoard();
            P2Turn = false;
            BottomMessage.Text = string.Empty;
        }

        protected void TPgame_Click(object sender, EventArgs e)
        {
            GameInProgress = true;
            AgainstAI = false;
            clearBoard();
            P2Turn = false;
            BottomMessage.Text = string.Empty;
        }

        protected void Board_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!GameInProgress) return;
            if (button.Text.Equals("X") || button.Text.Equals("O")) return;
            int target = button.ID[6] - '1';
            if (AgainstAI)
            {
                P2Turn = false; 
                button.Text = "X";
                Board[target / 3, target % 3] = "X";
                Turn++;
                if (Turn < 9)
                {
                    AIPick(sender);
                    Turn++;
                }
            }
            else
            {
                button.Text = P2Turn ? "O" : "X";
                Board[target / 3, target % 3] = P2Turn ? "O" : "X";
                Turn++;
                P2Turn = !P2Turn;
            }
            int winResult = WinCheck();
            if (winResult == 0) return;
            if (winResult == -1)
            {
                BottomMessage.Text = "It's a draw!";
            }
            if (winResult == 1)
            {
                BottomMessage.Text = "Player 1 Wins!";
            }
            if (winResult == 2)
            {
                if (AgainstAI) BottomMessage.Text = "AI Wins!";
                else BottomMessage.Text = "Player 2 Wins!";
            }
            if (winResult != 0)
            {
                GameInProgress = false; 
            }
        }

        protected int WinCheck() //possible return values: -1 draw, 0 game in play, 1 player 1, 2 player 2 wins
        {

            for (int i = 0; i < 3; i++)
            {
                if (Board[i, 0].Equals("X") && Board[i, 1].Equals("X") && Board[i, 2].Equals("X")) return 1;
                if (Board[0, i].Equals("X") && Board[1, i].Equals("X") && Board[2, i].Equals("X")) return 1;
            }
            if (Board[0, 0].Equals("X") && Board[1, 1].Equals("X") && Board[2, 2].Equals("X")) return 1;
            if (Board[2, 0].Equals("X") && Board[1, 1].Equals("X") && Board[0, 2].Equals("X")) return 1;

            for (int i = 0; i < 3; i++)
            {
                if (Board[i, 0].Equals("O") && Board[i, 1].Equals("O") && Board[i, 2].Equals("O")) return 2;
                if (Board[0, i].Equals("O") && Board[1, i].Equals("O") && Board[2, i].Equals("O")) return 2;
            }
            if (Board[0, 0].Equals("O") && Board[1, 1].Equals("O") && Board[2, 2].Equals("O")) return 2;
            if (Board[2, 0].Equals("O") && Board[1, 1].Equals("O") && Board[0, 2].Equals("O")) return 2;


            if (Turn >= 9) return -1;
            return 0;
        }

        public void AIPick(object sender)
        {
            AIRandom(sender); //added a random method selector just for now, coding in something smart is long and hard
        }

        public void AIRandom(object sender)
        {
            Random rn = new Random();
            int guess;
            while (true)
            {
                guess = rn.Next(0, 9);
                if (!Board[guess / 3, guess % 3].Equals(" ")) continue;
                break;
            }
            Board[guess / 3, guess % 3] = "X";
            ButtonArray[guess / 3, guess % 3].Text = "O";
            Button button = (Button)sender;


        }
    }
}