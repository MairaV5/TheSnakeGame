using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSnakeGame
{
    public partial class Game : Form
    {
        Area area = new Area();
        Snake snake = new Snake();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Height = 560;
            this.Width = 560;

            this.Controls.Add(area);
            area.Top = 80;
            area.Left = 80;
            //area.Location = new Point(80, 80);

            //adding snake body
            snake.Render(this);
        }
    }
}
