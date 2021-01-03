using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movementtemp001
{
    public partial class Form1 : Form
    {

        int playerX = 15;
        int playerY = 15;

        bool moveLeft, moveRight, moveUp, moveDown;


        public Form1()
        {
            InitializeComponent();
        }

        private void playertime(object sender, EventArgs e)
        {

            if(moveLeft && player.Left > 0)
            {
                player.Left -= playerX;
            }
            if(moveRight && player.Left + player.Width < 781)
            {
                player.Left += playerX;
            }

            if(moveUp && player.Top > 0)
            {
                player.Top -= playerY;
            }

            if(moveDown && player.Top + player.Height < 567)
            {
                player.Top += playerY;
            }


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }
    }
}
