using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BouncingBalls
{
    public partial class Form1 : Form
    {
        private const int BallSize = 30;
        private const int Gravity = 1;
        private List<Ball> balls = new List<Ball>();
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(800, 600);
            timer = new Timer();
            timer.Interval = 16; // Około 60 klatek na sekundę
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Move();
                CheckCollisionWithWalls(ball);
            }
            CheckCollisionBetweenBalls();

            Invalidate(); // Odświeżenie ekranu
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var ball in balls)
            {
                e.Graphics.FillEllipse(Brushes.Red, ball.Position.X, ball.Position.Y, BallSize, BallSize);
            }
        }

        private void CheckCollisionWithWalls(Ball ball)
        {
            if (ball.Position.X <= 0 || ball.Position.X + BallSize >= this.ClientSize.Width)
            {
                ball.Velocity = new Point(-ball.Velocity.X, ball.Velocity.Y);
            }

            if (ball.Position.Y <= 0 || ball.Position.Y + BallSize >= this.ClientSize.Height)
            {
                ball.Velocity = new Point(ball.Velocity.X, (int)(-ball.Velocity.Y * 0.9f)); // Elastyczność (zmniejszamy prędkość pionową przy odbiciu)
            }
        }

        private void CheckCollisionBetweenBalls()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                for (int j = i + 1; j < balls.Count; j++)
                {
                    if (CheckCollision(balls[i], balls[j]))
                    {
                        SwapVelocities(balls[i], balls[j]);
                    }
                }
            }
        }

        private bool CheckCollision(Ball ball1, Ball ball2)
        {
            int distance = (int)Math.Sqrt(Math.Pow(ball1.Position.X - ball2.Position.X, 2) + Math.Pow(ball1.Position.Y - ball2.Position.Y, 2));
            return distance < BallSize;
        }

        private void SwapVelocities(Ball ball1, Ball ball2)
        {
            Point temp = ball1.Velocity;
            ball1.Velocity = ball2.Velocity;
            ball2.Velocity = temp;
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            balls.Add(new Ball(e.Location, new Point(5, -15)));
        }

    }

    public class Ball
    {
        public Point Position { get; set; }
        public Point Velocity { get; set; }
        private const int Gravity = 1;
        public Ball(Point position, Point velocity)
        {
            this.Position = position;
            this.Velocity = velocity;
        }

        public void Move()
        {
            Position = new Point(Position.X + Velocity.X, Position.Y + Velocity.Y);
            Velocity = new Point(Velocity.X, Velocity.Y + Gravity);
        }
    }
}
