using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperOOP
{
    class MineField
    {
        public MineField()
        {
            
        }

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
                    gridSize = new int[] { 16, 30 };
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
    }
}
