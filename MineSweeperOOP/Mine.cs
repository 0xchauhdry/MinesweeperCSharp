using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperOOP
{
    class Mine
    {
        public static int _numOfMines = MineField.setNumofMines(SelectLevel.Gamelevel);

        public Mine()
        {
            
        }

        public string[] generateMine(int x, int y)
        {
            Random rand = new Random();
            string[] mineLocation = new string[_numOfMines];
            for (int i = 0; i < _numOfMines; i++)
            {
                int randX = rand.Next(0, x);
                int randY = rand.Next(0, y);
                if (mineLocation.Contains($"{randX} {randY}"))
                {
                    int randx = rand.Next(0, randX);
                    int randy = rand.Next(0, randY);
                    mineLocation[i] = ($"{randx} {randy}");
                }
                else
                {
                    mineLocation[i] = ($"{randX} {randY}");
                }
            }
            return mineLocation;
        }
    }
}
