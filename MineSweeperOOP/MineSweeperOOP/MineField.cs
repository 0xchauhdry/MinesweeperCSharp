using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweeperOOP
{
    class MineField
    {
        public int[] setGridSize(string gameLevel)
        {
            int[] gridSize = new int[2];
            switch (gameLevel)
            {
                case "Easy":
                    gridSize = new int[] { 9, 9 };
                    break;
                case "Medium":
                    gridSize = new int[] { 16, 16 };
                    break;
                case "Hard":
                    gridSize = new int[] { 22 , 22 };
                    break;
                default:
                    gridSize = new int[] { 9, 9 };
                    break;
            }
            return gridSize;
        }

        public static int setNumofMines(string gameLevel)
        {
            int numOfMines;
            switch (gameLevel)
            {
                case "Easy":
                    numOfMines = 10;
                    break;
                case "Medium":
                    numOfMines = 40;
                    break;
                case "Hard":
                    numOfMines = 99;
                    break;
                default:
                    numOfMines = 10;
                    break;
            }
            return numOfMines;
        }

        public void revealBlanks(Button btn, FlowLayoutPanel pnl)
        {
            String[] bName = btn.Name.Split(' ');
            int bName0 = int.Parse(bName[0]);
            int bName1 = int.Parse(bName[1]);

            foreach (Button bb in pnl.Controls)
            {
                String[] bbName = bb.Name.Split(' ');
                int bbName0 = int.Parse(bbName[0]);
                int bbName1 = int.Parse(bbName[1]);
                int bbText = int.Parse(bb.Text);
                bool bbTag = Convert.ToBoolean(bb.Tag);

                if (bbName0 == bName0 - 1 && bbName1 == bName1 - 1 ||
                    bbName0 == bName0 - 1 && bbName1 == bName1 ||
                    bbName0 == bName0 - 1 && bbName1 == bName1 + 1 ||
                    bbName0 == bName0 && bbName1 == bName1 - 1 ||
                    bbName0 == bName0 && bbName1 == bName1 + 1 ||
                    bbName0 == bName0 + 1 && bbName1 == bName1 - 1 ||
                    bbName0 == bName0 + 1 && bbName1 == bName1 ||
                    bbName0 == bName0 + 1 && bbName1 == bName1 + 1)
                {
                    if (int.Parse(bb.Text) == 0)
                    {
                        bb.BackColor = Color.WhiteSmoke;
                        bb.Tag = true;
                    }
                    else if (int.Parse(bb.Text) != 9)
                    {
                        bb.BackColor = Color.WhiteSmoke;
                        bb.Text = int.Parse(bb.Text).ToString();
                        bb.Tag = true;
                    }
                    if (bbText == 0 && bbTag == false)
                    {
                        revealBlanks(bb, pnl);
                    }
                }

            }
        }

        public void addMineCount(FlowLayoutPanel pnl)
        {
            foreach (Button b in pnl.Controls)
            {
                String[] bName = b.Name.Split(' ');
                int bName0 = int.Parse(bName[0]);
                int bName1 = int.Parse(bName[1]);
                int bText = int.Parse(b.Text);

                if (bText == 9)
                {
                    foreach (Button bb in pnl.Controls)
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
                                bb.Text = "     " + (int.Parse(bb.Text) + 1).ToString();
                            }
                        }

                    }
                }
            }
        }
    }
}
