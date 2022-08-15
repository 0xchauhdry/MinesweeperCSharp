using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweeperOOP
{
    class Logic
    {
        public void GameWon(Timer t,int tc, FlowLayoutPanel pnl)
        {
            t.Stop();
            MessageBox.Show($"You Won in {tc} seconds", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnl.Controls.Clear();
        }

        public void gameOver(Timer t, FlowLayoutPanel pnl)
        {
            t.Stop();
            MessageBox.Show("You Lose :(", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            pnl.Controls.Clear();
        }

        public void CheckResults(Timer t, int tc, FlowLayoutPanel pnl)
        {
            int count = 0;
            foreach (Button b in pnl.Controls)
            {
                MineField newMineField = new MineField();
                int[] grid = newMineField.setGridSize(SelectLevel.Gamelevel);
                bool bTag = Convert.ToBoolean(b.Tag);
                if (bTag == true)
                {
                    count++;
                }
                if (count == (grid[0] * grid[1]))
                {
                    GameWon(t, tc, pnl);
                }
            }
        }
    }
}
