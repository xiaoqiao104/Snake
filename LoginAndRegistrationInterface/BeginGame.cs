using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace LoginAndRegistrationInterface
{
    public partial class BeginGame : Form
    {
        Snake sna = new Snake();
        Food food = new Food();
        BabMusic music = new BabMusic();
        public static int score = 0;
        public bool eated = false;
        public BeginGame()
        {
            music.PlayMusic();
            InitializeComponent();
            this.Width = 800;
            this.Height = 600;
            Snakeshow();

            Label label2 = food.food1();
            this.Controls.Add(label2);

        }
        public void Snakeshow()
        {
            for (int i = 0; i < 2; i++)
            {
                Label label = new Label();
                label.Width = 20;
                label.Height = 20;
                label.Top = 100;
                label.Left = 500 + i * 20;
                label.BackColor = Color.Black;
                this.Controls.Add(label);
                sna.labels[i] = label;
            }

        }
        private void BeginGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1_Tick(null,null);
        }
        ////定时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            sna.Move();
            eat();
            Wall();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            sna.key(e.KeyCode);
        }
        //撞墙
        private void Wall()
        {
            if (sna.labels[0].Top < 0 || sna.labels[0].Top > 600 || sna.labels[0].Left < 0 || sna.labels[0].Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("撞墙了，游戏结束!");
                GameOver gameOver = new GameOver();
                gameOver.Show();
            }
        }
        //蛇吃食物
        public void eat()
        {
            if ((sna.labels[0].Left == food.label2.Left && sna.labels[0].Top == food.label2.Top))

            {
                eated = true;
                score += 2;
                if (score == 6)
                {
                    timer1.Stop();
                    MessageBox.Show("闯到第二关啦！");
                    Label label3 = food.food2();
                    this.Controls.Add(label3);
                    timer1.Interval = 400;
                    timer1.Start();
                }
                if (score == 12)
                {
                    timer1.Stop();
                    MessageBox.Show("恭喜闯关成功！");
                    this.Hide();
                    GameOver gameOver = new GameOver();
                    gameOver.Show();
                }

                else
                {
                    sna.length++;
                    Label snake_length = sna.SnaLength();
                    this.Controls.Add(sna.SnaLength());
                    beichi();
                }
            }
            if (score >= 6)
            {
                if ((sna.labels[0].Left == food.label3.Left &&sna. labels[0].Top == food.label3.Top))
                {
                    eated = false;
                    score += 2;
                    timer1.Stop();
                    timer1.Interval = 400;
                    timer1.Start();
                    sna.length++;
                    Label snake_length = sna.SnaLength();
                    this.Controls.Add(sna.SnaLength());
                    beichi();
                    if (score == 12)
                    {
                        timer1.Stop();
                        MessageBox.Show("恭喜闯关成功！");
                        this.Hide();
                        GameOver gameOver = new GameOver();
                        gameOver.Show();
                    }
                }
                
            }
        }
        //判断进入哪一关卡
        public void beichi()
        {
            if (eated == true)
            {
                Label label2 = food.food1();
                this.Controls.Add(label2);
            }
            else
            {
                Label label3 = food.food2();
                this.Controls.Add(label3);
            }

        }

        private void BeginGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
