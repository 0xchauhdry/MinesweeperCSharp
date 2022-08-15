using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperOOP
{
    public partial class Minesweeper : Form
    {
        int flagsLeft;
        int[] grid;
        int timerCount;
        public Minesweeper()
        {
            SelectLevel level = new SelectLevel();
            level.ShowDialog();
            InitializeComponent();
        }

        public void createMineField()
        {
            pnlMineField.Controls.Clear();

            flagsLeft = Mine._numOfMines;
            lblflags.Text = flagsLeft.ToString();

            MineField newMineField = new MineField();
            grid = newMineField.setGridSize(SelectLevel.Gamelevel);

            Mine newMine = new Mine();
            string[] minesLocation = newMine.generateMine(grid[0],grid[1]);

            pnlMineField.Size = new Size(20* grid[0], 20* grid[1]);

            for (int i = 0; i < grid[0]; i++)
            {
                for (int j = 0; j < grid[1]; j++)
                {
                    Button btnMineField = new Button()
                    {
                        //Location = new Point(10 + i * 20, 50 + j * 20),
                        Name = $"{i} {j}",
                        Text = "    0",
                        Size = new Size(20, 20),
                        UseVisualStyleBackColor = true,
                        BackColor = Color.Gray,
                        Tag = false,
                        Margin = new Padding(0),
                    };
                    for(int k = 0; k < minesLocation.Length ;k++) 
                    {
                        if (minesLocation[k] == btnMineField.Name)
                        {
                            btnMineField.Text = "   9";
                            btnMineField.Tag = true;
                        }
                    }
                    btnMineField.MouseDown += BtnMineField_MouseDown;
                    pnlMineField.Controls.Add(btnMineField);
                }
            }
        }

        private void BtnMineField_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btnTemp = sender as Button;

                if (btnTemp.BackColor != Color.WhiteSmoke)
                {
                    if (btnTemp.BackColor == Color.Green)
                    {
                        btnTemp.BackColor = Color.Gray;
                        flagsLeft++;
                    }
                    else
                    {
                        btnTemp.BackColor = Color.Green;
                        flagsLeft--;
                    }
                }
                lblflags.Text = flagsLeft.ToString();
                Logic gameLogic = new Logic();
                gameLogic.CheckResults(timer,timerCount,pnlMineField);
            }
            if (e.Button == MouseButtons.Left)
            {
                Button btnTemp = sender as Button;
                if (btnTemp.BackColor != Color.Green) 
                {
                    if (int.Parse(btnTemp.Text) == 0)
                    {
                        btnTemp.BackColor = Color.WhiteSmoke;
                        btnTemp.Tag = true;
                        MineField newMineField = new MineField();
                        newMineField.revealBlanks(btnTemp, pnlMineField);
                    }
                    else if (int.Parse(btnTemp.Text) == 9)
                    {
                        btnTemp.BackColor = Color.Red;
                        Logic gameLogics = new Logic();
                        gameLogics.gameOver(timer,pnlMineField);
                    }
                    else
                    {
                        btnTemp.BackColor = Color.WhiteSmoke;
                        btnTemp.Text = int.Parse(btnTemp.Text).ToString();
                        btnTemp.Tag = true;
                    }
                }
                Logic gameLogic = new Logic();
                gameLogic.CheckResults(timer, timerCount, pnlMineField);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            createMineField();
            MineField newMineField = new MineField();
            newMineField.addMineCount(pnlMineField);
            timer.Start();
            timerCount = 0;
            foreach (Button b in pnlMineField.Controls)
            {
                int bText = int.Parse(b.Text);
                if (bText == 0)
                {
                    newMineField.revealBlanks(b,pnlMineField);
                    break;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerCount++;
            lbltimer.Text = timerCount.ToString();
        }
    }
}
