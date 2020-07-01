using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Media;

namespace LoginAndRegistrationInterface
{
    class Food:Form
    {
        public Label label2 = new Label();
        public Label label3 = new Label();
        //随机产生食物

        public Label food1()
        {
            label2.Width = label2.Height = 20;
            label2.BackColor = Color.Blue;
            Random random = new Random();
            label2.Top = random.Next(1, 20) * 20;
            label2.Left = random.Next(1, 20) * 20;
            return label2;
        }
        public Label food2()
        {
            label3.Width = label3.Height = 20;
            label3.BackColor = Color.Blue;
            Random random1 = new Random();
            label3.Top = random1.Next(3, 15) * 20;
            label3.Left = random1.Next(3, 15) * 20;
            //如果两个食物重合
            if (label2.Top == label3.Top && label2.Left == label3.Left)
            {
                label3.Top = random1.Next(3, 15) * 20;
                label3.Left = random1.Next(3, 15) * 20;
            }
            return label3;
        }
    }
}
