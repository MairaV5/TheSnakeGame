using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSnakeGame
{
    class Snake
    {
        List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            this.AddPixel(275, 275);
            this.AddPixel(275, 295);
            this.AddPixel(275, 315);
        }

        private void AddPixel(int left, int top)
        {
            PictureBox snakePixel;
            snakePixel = new PictureBox();
            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.BackColor = Color.Green;
            snakePixel.Left = left;
            snakePixel.Top = top;
            snakePixels.Add(snakePixel);
        }

        public void Render(Form form)
        {
            foreach(var sp in snakePixels)
            {
                form.Controls.Add(sp);
                sp.BringToFront();
            }
        }
    }
}
