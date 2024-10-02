using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameSnake
{
    public partial class Form1 : Form
    {
        private const string MUSIC_PATH = "..\\..\\Resources\\gameMusic.wav";
        private const string NO_VOLUME_PATH = "..\\..\\Resources\\noVolume.png";
        private const string VOLUME_PATH = "..\\..\\Resources\\Volume.png";

        public Random random = new Random();
        SolidBrush snake = new SolidBrush(Color.Red);


        Pen pen;
        Graphics g;
        Queue<Coordinates> coordinates;
        int snakeSize = 40;

        int x = 50;
        int y = 50;
        bool[] coords = new bool[4] { false, false, false, true }; 

        int size = 20;
        int step = 3;

        private bool flag = true;

        private SoundPlayer player = new SoundPlayer(); 

        private Point foodPosition;
        private int foodSize = 20;
        SolidBrush foodBrush;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = MUSIC_PATH;
            player.PlayLooping(); 

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            timer1.Interval = 10;
            coordinates = new Queue<Coordinates>(snakeSize);
            pen = new Pen(Color.Red, 6);
            PlaceFood(); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.W:
                    coords[0] = true;
                    coords[1] = coords[2] = coords[3] = false;
                    break;

                case Keys.S:
                    coords[1] = true;
                    coords[0] = coords[2] = coords[3] = false;
                    break;

                case Keys.D:
                    coords[3] = true;
                    coords[1] = coords[2] = coords[0] = false;
                    break;

                case Keys.A:
                    coords[2] = true;
                    coords[0] = coords[1] = coords[3] = false;
                    break;
            }

        }

        private void MoveSnake()
        {
            if (coords[0])
                y -= step;
            else if (coords[1])
                y += step;
            else if (coords[2])
                x -= step;
            else if (coords[3])
                x += step;

            if (x >= this.ClientSize.Width || x <= 4 || y <= 4 || y >= this.ClientSize.Height)
            {
                EndGame();
                MessageBox.Show("You lose");
            }

            if (coordinates.Count != snakeSize)
                coordinates.Enqueue(new Coordinates(x, y));
            else
            {
                Coordinates removed = coordinates.Dequeue();
                g.FillEllipse(new SolidBrush(this.BackColor), removed.X, removed.Y, size, size);
                coordinates.Enqueue(new Coordinates(x, y));
            }

            if (Math.Abs(x - foodPosition.X) < size && Math.Abs(y - foodPosition.Y) < size)
            {
                
                snakeSize+=3; 
                step += 1;

                g.FillEllipse(new SolidBrush(this.BackColor), foodPosition.X, foodPosition.Y, foodSize, foodSize);
                if (count <= 9)
                {
                    PlaceFood(); 
                    DrawSnakeFood();
                    count++;
                }
                else 
                { 
                    EndGame();
                    MessageBox.Show("YOU WINNN");
                }
            } 
        }

        private void EndGame()
        {
            timer1.Stop();
            this.Hide();
            player.Stop();
            player.Dispose();
            snake.Dispose();
            pen.Dispose();
            g.Dispose();
            pbVolume.Image.Dispose();
        }

        private void DrawSnake()
        {
            foreach (var pair in coordinates)
            {
                g.FillEllipse(snake, pair.X, pair.Y, size, size);
            }
            g.DrawRectangle(pen, 3, 3, this.ClientSize.Width - 6, this.ClientSize.Height - 6);
        }

        private void DrawSnakeFood()
        {
            
            foodBrush = new SolidBrush(Color.FromArgb(220, random.Next(255), random.Next(255), random.Next(255)));
            g.FillEllipse(foodBrush, foodPosition.X, foodPosition.Y, foodSize, foodSize);
        }

        private void lblSnakeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                snake = new SolidBrush(colorDialog1.Color);
            }
        }

        private void lblBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void lblFrameColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                 player.Stop();
                 pbVolume.Image = Image.FromFile(NO_VOLUME_PATH);
                 flag = false; 
            }
            else
            {
                  player.Play();
                  pbVolume.Image = Image.FromFile(VOLUME_PATH);
                  flag = true;
            }
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            pbGitHub.Visible = false;
            pbGitHub.Visible = false;
            pbHome.Visible = false;
            pbLinkedin.Visible = false;
            pbSettings.Visible = false;
            pbStart.Visible = false;
            pbLogoGame.Visible = false;
            pbVolume.Visible = false;
            

            lblGameName.Visible = false;
            lblContacts.Visible = false;


            g.DrawRectangle(pen, 3, 3, this.ClientSize.Width - 6, this.ClientSize.Height - 6);//Рамка
            DrawSnakeFood();

            
            this.Focus();
            timer1.Start();
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            lblBackgroundColor.Visible = true;
            lblSnakeColor.Visible = true;
            lblFrameColor.Visible = true;
            pbHome.Visible = true;

            pbStart.Visible = false;
            pbSettings.Visible = false;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            pbStart.Visible = true;
            pbSettings.Visible = true;
            pbHome.Visible = false;

            lblBackgroundColor.Visible = false;
            lblSnakeColor.Visible = false;
            lblFrameColor.Visible = false;
        }

        private void pbGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Bozhidar-Yovchev");
        }

        private void pbLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/bozhidar-yovchev/");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Dispose();

            if (pen != null)
                pen.Dispose();

            if (snake != null)
                snake.Dispose();

            if (g != null)
            {
                g.Dispose();
            }

            if (pbVolume.Image != null)
            {
                pbVolume.Image.Dispose();
            }
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawSnake();
            MoveSnake();
        }

        private void PlaceFood()
        {
            foodPosition = new Point(random.Next(15, this.ClientSize.Width - 30), random.Next(15, this.ClientSize.Height - 30));
        }
    }
}
