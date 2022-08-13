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
    public partial class SelectLevel : Form
    {
        public static string Gamelevel;
        public SelectLevel()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Gamelevel = btnEasy.Text;
            Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Gamelevel = btnMedium.Text;
            Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Gamelevel = btnHard.Text;
            Close();
        }
    }
}
