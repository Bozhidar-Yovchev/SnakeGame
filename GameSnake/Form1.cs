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

namespace GameSnake
{
    public partial class Form1 : Form
    {
        //private const string MUSIC_PATH = "Resources/gameMusic.wav";

        public Random random = new Random();
        SolidBrush snake;


        Pen pen;
        Graphics g;
        Queue<Coordinates> coordinates;
        int snakeSize = 40;//Първоначална дължина на змията

        int x = 50;
        int y = 50;
        bool[] coords = new bool[4] { false, false, false, true }; // нагоре надолу наляво надясно

        int size = 15;
        int step = 4;//С колко да се движи

        private bool flag = true;

        // private SoundPlayer player = new SoundPlayer(); // Звук на играта
        
        public Form1()
        {
            InitializeComponent();
            //player.SoundLocation = MUSIC_PATH;//Файлът, който се използва
            //player.PlayLooping(); //За пускане на музиката за постоянно 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            timer1.Interval = 10;
            coordinates = new Queue<Coordinates>(snakeSize);
            this.Size = new Size(800, 800);
            pen = new Pen(Color.Red, 6);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // начините на движение
            switch (e.KeyCode)
            {
                case Keys.Up:
                    coords[0] = true;
                    coords[1] = coords[2] = coords[3] = false;
                    break;

                case Keys.Down:
                    coords[1] = true;
                    coords[0] = coords[2] = coords[3] = false;
                    break;

                case Keys.Right:
                    coords[3] = true;
                    coords[1] = coords[2] = coords[0] = false;
                    break;

                case Keys.Left:
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




            if (x >= this.Size.Width || x <= 4)//Когато достигне края на полето по дължина да свършва играта
            {
                timer1.Stop();
                this.Hide();
                //player.Stop();
                GameOverForm gameOverForm = new GameOverForm();
                gameOverForm.ShowDialog();
            }

            else if (y <= 4 || y >= this.Size.Height)//Когато достигне края на полето по височина да свършва играта
            {
                timer1.Stop();
                this.Hide();
               // player.Stop();
                GameOverForm gameOverForm = new GameOverForm();
                gameOverForm.ShowDialog();

            }

            if (coordinates.Count != snakeSize)
                coordinates.Enqueue(new Coordinates(x, y));
            else
            {
                Coordinates removed = coordinates.Dequeue();//Премахва изминатите кординати от змията
                g.FillEllipse(new SolidBrush(this.BackColor), removed.X, removed.Y, size, size);
                coordinates.Enqueue(new Coordinates(x, y));//Добавя новите кординати на змията
            }
        }
        private void Draw()
        {
            snake = new SolidBrush(Color.Red);// Змия :)
            foreach (var pair in coordinates)
            {
                g.FillEllipse(snake, pair.X, pair.Y, size, size);// Изчертаване на змията

            }
        }

        private void DrawSnakeFood()
        {
            g = this.CreateGraphics();

            for (int i = 0; i < 30; i++)
            {
                SolidBrush food = new SolidBrush(Color.FromArgb(200, random.Next(255), random.Next(255), random.Next(255)));
                g.FillEllipse(food, random.Next(800), random.Next(800), 15, 15);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//Затваря програмата
        }

        private void lblSnakeColor_Click(object sender, EventArgs e)
        {
            //Цвят на змията
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                snake.Color = colorDialog1.Color;
            }
        }

        private void lblBackgroundColor_Click(object sender, EventArgs e)
        {
            //Цвят на фона
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void lblFrameColor_Click(object sender, EventArgs e)
        {
            //цвят на рамката
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            if (flag)
            {
               // player.Stop();
                pbVolume.Image = Image.FromFile("..\\..\\Resources\\noVolume.png");
                flag = false;
            }
            else
            {
               // player.Play();
                pbVolume.Image = Image.FromFile("..\\..\\Resources\\Volume.png");
                flag = true;
            }
        }
    }
}
