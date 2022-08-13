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

                if (btnTemp.BackColor == Color.Green)
                {
                    btnTemp.BackColor = Color.Gray;
                    flagsLeft++;
                    btnTemp.Tag = false;
                }
                else if (flagsLeft >= 1)
                {
                    btnTemp.BackColor = Color.Green;
                    flagsLeft--;
                    btnTemp.Tag = true;
                }
                lblflags.Text = flagsLeft.ToString();
                CheckResults();
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
                        revealBlanks(btnTemp);
                    }
                    else if (int.Parse(btnTemp.Text) == 9)
                    {
                        btnTemp.BackColor = Color.Red;
                        gameOver();
                    }
                    else
                    {
                        btnTemp.BackColor = Color.WhiteSmoke;
                        btnTemp.Text = int.Parse(btnTemp.Text).ToString();
                        btnTemp.Tag = true;
                    }
                }
                CheckResults();
            }
        }

        private void addMineCount()
        {
            foreach (Button b in pnlMineField.Controls)
            {
                String[] bName = b.Name.Split(' ');
                int bName0 = int.Parse(bName[0]);
                int bName1 = int.Parse(bName[1]);
                int bText = int.Parse(b.Text);

                if (bText == 9)
                {
                    foreach (Button bb in pnlMineField.Controls)
                    {
                        String[] bbName = bb.Name.Split(' ');
                        int bbName0 = int.Parse(bbName[0]);
                        int bbName1 = int.Parse(bbName[1]);
                        int bbText = int.Parse(bb.Text);

                        if (bbName0 == bName0 - 1 && bbName1 == bName1 - 1 ||
                            bbName0 == bName0 - 1 && bbName1 == bName1 ||
                            bbName0 == bName0 - 1 && bbName1 == bName1 + 1 ||
                            bbName0 == bName0 && bbName1 == bName1 - 1 ||
                            bbName0 == bName0 && bbName1 == bName1 + 1 ||
                            bbName0 == bName0 + 1 && bbName1 == bName1 - 1 ||
                            bbName0 == bName0 + 1 && bbName1 == bName1 ||
                            bbName0 == bName0 + 1 && bbName1 == bName1 + 1)
                        {
                            if (bbText != 9)
                            {
                                bb.Text = "     "+(int.Parse(bb.Text) + 1).ToString();
                            }
                        }

                    }
                }
            }
        }

        private void revealBlanks(Button btn)
        {
            String[] bName = btn.Name.Split(' ');
            int bName0 = int.Parse(bName[0]);
            int bName1 = int.Parse(bName[1]);

            foreach (Button bb in pnlMineField.Controls)
            {
                String[] bbName = bb.Name.Split(' ');
                int bbName0 = int.Parse(bbName[0]);
                int bbName1 = int.Parse(bbName[1]);
                int bbText = int.Parse(bb.Text);
                bool bTag = Convert.ToBoolean(bb.Tag);

                if (bbName0 == bName0 - 1 && bbName1 == bName1 - 1 ||
                    bbName0 == bName0 - 1 && bbName1 == bName1 ||
                    bbName0 == bName0 - 1 && bbName1 == bName1 + 1 ||
                    bbName0 == bName0 && bbName1 == bName1 - 1 ||
                    bbName0 == bName0 && bbName1 == bName1 + 1 ||
                    bbName0 == bName0 + 1 && bbName1 == bName1 - 1 ||
                    bbName0 == bName0 + 1 && bbName1 == bName1 ||
                    bbName0 == bName0 + 1 && bbName1 == bName1 + 1)
                {
                    if (int.Parse(btn.Text) == 0)
                    {
                        btn.BackColor = Color.WhiteSmoke;
                        btn.Tag = true;
                    }
                    else
                    {
                        btn.BackColor = Color.WhiteSmoke;
                        btn.Text = int.Parse(btn.Text).ToString();
                        btn.Tag = true;
                    }
                    if (bbText == 0 && bTag == false)
                    {
                        revealBlanks(bb);
                    }
                }

            }
        }

        private void GameWon()
        {
            MessageBox.Show("You Won ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Controls.Clear();
        }

        private void gameOver()
        {
            MessageBox.Show("You Lose :(", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);

            pnlMineField.Controls.Clear();
        }

        private void CheckResults()
        {
            int count = 0;
            foreach (Button b in pnlMineField.Controls)
            {
                bool bTag = Convert.ToBoolean(b.Tag);
                if (bTag == true)
                {
                    count++;
                }
                if (count == grid[0]*grid[1])
                {
                    GameWon();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            createMineField();
            addMineCount();
            foreach (Button b in pnlMineField.Controls)
            {
                int bText = int.Parse(b.Text);
                if (bText == 0)
                {
                    revealBlanks(b);
                    break;
                }
            }
        }
    }
}
