using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace astronaut_2D
{
    public partial class Form1 : Form
    {
        int playerSpeed;

        PictureBox[] moonrocks;
        int moonroksCount;

        PictureBox[] enemies;
        int enemiesSpeed;
        int enemiesCount;
        int kills;
        int health;

        PictureBox[] bullets;
        int bulletsSpeed;

        Random random;

        Image EnemiesImg = Image.FromFile("assets\\enemy_moving.gif");
        Image DeadEnemy = Image.FromFile("assets\\enemy_death.gif");
        Image HurtedEnemy = Image.FromFile("assets\\enemy_hurt.png");
        Image EnemyEating = Image.FromFile("assets\\enemy_attack.gif");

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            playerSpeed = 3;
            Player.Image = Properties.Resources.astronaut_staying2;

            random = new Random();
            
            bullets = new PictureBox[1];
            bulletsSpeed = 30;

            for(int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(30, 5);
                bullets[i].BackColor = Color.White;

                this.Controls.Add(bullets[i]);
            }

            enemiesCount = 5;
            enemies = new PictureBox[enemiesCount];
            enemiesSpeed = 1;

            kills = 0;
            health = 10000;

            moonroksCount = 3;
            moonrocks = new PictureBox[moonroksCount];
         
            Image moonrock = Image.FromFile("assets\\moonrock_light.gif");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(random.Next(100, 130), random.Next(100, 130));
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = EnemiesImg;
                enemies[i].Location = new Point((i + 2) * random.Next(50, 150) + 1000, random.Next(400, 650));

                this.Controls.Add(enemies[i]);
            }

            for (int i = 0; i < moonrocks.Length; i++)
            {
                moonrocks[i] = new PictureBox();
                moonrocks[i].BackColor = Color.Transparent;
                moonrocks[i].Image = moonrock;
                moonrocks[i].Location = new Point((i + 2) * random.Next(50, 150), random.Next(400, 650));

                this.Controls.Add((moonrocks[i]));
            }

            MovingEnemies.Stop();
            Rules($"Цель игры состоит в том, чтобы не дать врагам " +
                $"\nдобраться до лунных камней (подсвечиваются " +
                $"\nфиолетовым на карте) и не погибнуть. " +
                $"\nУправление: " +
                $"\nдвижение - стрелки клавиатуры, " +
                $"\nстрельба - пробел." +
                $"\nНажмите пробел чтобы начать.");

            Statistics($"Здоровье: {(health / 100).ToString()} \nУбийства: {kills.ToString()} " +
                $"\nКамни: {moonroksCount.ToString()}");


        }

        private void MovingLeft_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
                Player.Left -= playerSpeed;
        }

        private void MovingRight_Tick(object sender, EventArgs e)
        {
            if (Player.Left < 1150 )
                Player.Left += playerSpeed;
        }

        private void MovingTop_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 320)
                Player.Top -= playerSpeed;
        }

        private void MovingDown_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 510)
                Player.Top += playerSpeed;
        }

        private void ShootingBullets_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Left += bulletsSpeed;
            }
        }

        private void MovingEnemies_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Left -= enemiesSpeed;

                IsIntersected();

                if (enemies[i].Left < 50)
                {
                    enemies[i].Size = new Size(random.Next(100, 130), random.Next(100, 130));
                    enemies[i].Location = new Point((i + 1) * random.Next(50, 150) + 1000, random.Next(400, 650));
                    enemies[i].Image = EnemiesImg;
                }
            }
        }

        private void rocks_lightning_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < moonrocks.Length; i++)
            {
                moonrocks[i].Left += 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MovingLeft.Start();
                Player.Image = Properties.Resources.astronaut_back;
            }
            if (e.KeyCode == Keys.Right)
            {
                MovingRight.Start();
                Player.Image = Properties.Resources.astronaut;
            }
            if (e.KeyCode == Keys.Up)
            {
                MovingTop.Start();
                Player.Image = Properties.Resources.astronaut;
            }
            if (e.KeyCode == Keys.Down)
            {
                MovingDown.Start();
                Player.Image = Properties.Resources.astronaut_back;
            }
            if (e.KeyCode == Keys.Space)
            {
                label4.Visible = false;
                Player.Image = Properties.Resources.astronaut_shoot;
                for (int i = 0; i < bullets.Length; i++)
                {
                    IsIntersected();

                    if (bullets[i].Left > 1280)
                    {
                        bullets[i].Location = new Point(Player.Location.X + 30 + i * 50, Player.Location.Y + 100);
                        break;
                    }
                }               
            }
            Statistics($"Здоровье: {(health / 100).ToString()} \nУбийства: {kills.ToString()} " +
                $"\nКамни: {moonroksCount.ToString()}");
        }

        private void IsIntersected()
        {
            for (int i = 0;i < enemies.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    enemies[i].Image = DeadEnemy;
                    MovingEnemies.Stop();
                    enemies[i].Location = new Point((i + 2) * random.Next(50, 125) + 1000, random.Next(380, 600));
                    enemies[i].Image = EnemiesImg;
                    bullets[0].Location = new Point((2000), Player.Location.Y + 50);
                    kills += 1;
                    Statistics($"Здоровье: {(health / 100).ToString()} \nУбийства: {kills.ToString()} " +
                $"\nКамни: {moonroksCount.ToString()}");
                }

                for (int j = 0; j < moonrocks.Length; j++)
                {
                    if (moonroksCount == 0)
                    {
                        GameOver("Игра окончена!");
                        MovingEnemies.Stop();
                    }
                    if (moonrocks[j].Bounds.IntersectsWith(enemies[i].Bounds))
                    {
                        enemies[i].Image = EnemyEating;
                        moonroksCount -= 1;
                        enemiesCount += 1;
                        moonrocks[j].Location = new Point(-100, -100);
                    }
                    Statistics($"Здоровье: {(health / 100).ToString()} \nУбийства: {kills.ToString()} " +
                $"\nКамни: {moonroksCount.ToString()}");
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {                 
                    if (health <= 0)
                    {
                        Player.Visible = false;
                        enemies[i].Image = EnemyEating;
                        GameOver("Игра окончена!");
                    }
                    health = health - 25;
                    Statistics($"Здоровье: {(health / 100).ToString()} \nУбийства: {kills.ToString()} " +
                 $"\nКамни: {moonroksCount.ToString()}");
                    break;
                }
                           
                MovingEnemies.Start();
            }
        }

        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(327, 175);
            label1.Visible = true;

            MovingEnemies.Stop();
            rocks_lightning.Stop();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Player.Image = Properties.Resources.astronaut_staying2;
            MovingLeft.Stop();
            MovingRight.Stop();
            MovingTop.Stop();
            MovingDown.Stop();           
        }       

        private void Rules(string str)
        {
            label4.Text = str;
            label4.Location = new Point(266, 131);
            label4.Visible = true;
        }

        private void Statistics(string str)
        {
            label2.Text = str;
            label2.Location = new Point(12, 9);
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }
    }
}
