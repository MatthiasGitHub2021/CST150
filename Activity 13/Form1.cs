using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        //For 1 and 0s
        Random random = new Random();

        private void BTN_NewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
            onesToXs();
        }

        private void StartNewGame()
        {
            //Make gameboard with 2d array
            int[,] gameBoard = new int[3,3];

            //fill 2d array with 1 and 0s
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = random.Next(0, 2);
                }           
            }

            //display game board with results
            TopLeft.Text = gameBoard[0, 0].ToString();
            TopMiddle.Text = gameBoard[0, 1].ToString();
            TopRight.Text = gameBoard[0, 2].ToString();
            MiddleLeft.Text = gameBoard[1, 0].ToString();
            MiddleMiddle.Text = gameBoard[1, 1].ToString();
            MiddleRight.Text = gameBoard[1, 2].ToString();
            BottomLeft.Text = gameBoard[2, 0].ToString();
            BottomMiddle.Text = gameBoard[2, 1].ToString();
            BottomRight.Text = gameBoard[2, 2].ToString();

            //winner logic
            if (gameBoard[0, 0] == 0 && gameBoard[0, 1] == 0 && gameBoard[0, 2] == 0 || //row 1 across
                gameBoard[1, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[1, 2] == 0 || //row 2 across
                gameBoard[2, 0] == 0 && gameBoard[2, 1] == 0 && gameBoard[2, 2] == 0 || //row 3 across
                gameBoard[0, 0] == 0 && gameBoard[1, 0] == 0 && gameBoard[2, 0] == 0 || //col 1 down
                gameBoard[0, 1] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 1] == 0 || //col 2 down
                gameBoard[0, 2] == 0 && gameBoard[1, 2] == 0 && gameBoard[2, 2] == 0 || //col 3 down
                gameBoard[0, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 2] == 0 || //top left to bottom right
                gameBoard[2, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[0, 2] == 0    //bottom left to top right
                )
            {
                LBL_Winner.Text = "O has won the game.";
            }
            else if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1 ||
                gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1 ||
                gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1 ||
                gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1 ||
                gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1 ||
                gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1 ||
                gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1 ||
                gameBoard[2, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[0, 2] == 1
                )
            {
                LBL_Winner.Text = "X has won the game.";
            }
            else 
            {
                LBL_Winner.Text = "Draw";
            }
        }

        //Make array of textboxes and foreach 1 change the text to X
        private void onesToXs()
        {
            List<TextBox> list = new List<TextBox>();
            list.Add(TopLeft);
            list.Add(TopMiddle);
            list.Add(TopRight);
            list.Add(MiddleLeft);
            list.Add(MiddleMiddle);
            list.Add(MiddleRight);
            list.Add(BottomLeft);
            list.Add(BottomMiddle);
            list.Add(BottomRight);

            string compareTo = "1";

            foreach (TextBox textBox in list)
            {  
                if(textBox.Text == compareTo)
                {
                    textBox.Text = "X";
                }
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
