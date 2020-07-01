using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginAndRegistrationInterface
{
    class Snake:Form
    {
        
        public Label[] labels = new Label[100];
        public int length = 2;//蛇的初始长度
        public Keys keys = Keys.A;
        public void Move()
        {
            
            //蛇身移动
            for (int i = length - 1; i > 0; i--)
            {
              
                labels[i].Left = labels[i - 1].Left;
                labels[i].Top = labels[i - 1].Top;
            }

            //蛇头移动
            switch (keys)
            {
                case Keys.A:
                    labels[0].Left -= 20;
                    break;
                case Keys.D:
                    labels[0].Left += 20;
                    break;
                case Keys.W:
                    labels[0].Top -= 20;
                    break;
                case Keys.S:
                    labels[0].Top += 20;
                    break;
            }
        }
        public void key(Keys k)
        {
            switch (k)
            {

                case Keys.A:
                    if (keys != Keys.D)
                    {
                        keys = Keys.A;


                    }
                    break;
                case Keys.D:
                    if (keys != Keys.A)
                    {
                        keys = Keys.D;

                    }
                    break;
                case Keys.W:
                    if (keys != Keys.S)
                    {
                        keys = Keys.W;

                    }
                    break;
                case Keys.S:
                    if (keys != Keys.W)
                    {
                        keys = Keys.S;

                    }
                    break;
            }
        }
        public Label SnaLength()
        {
            Label snake_length = new Label();
            snake_length.Width = 20;
            snake_length.Height = 20;
            snake_length.BackColor = Color.Black;
            snake_length.Top = labels[length - 2].Top;
            snake_length.Left = labels[length - 2].Left;
            labels[length - 1] = snake_length;
            return snake_length;
           
        }
    }
}
