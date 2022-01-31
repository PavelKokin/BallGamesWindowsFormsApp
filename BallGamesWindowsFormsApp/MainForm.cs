using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        PointAndSizeRandomBall pointAndSizeRandomBall;
        List<MoveBall> balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void createBallButton_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
            ball.Show();
        }

        private void createRandomPointButton_Click(object sender, EventArgs e)
        {
            pointAndSizeRandomBall = new PointAndSizeRandomBall(this);
            pointAndSizeRandomBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].IsMoved() && balls[i].Exists(e.X, e.Y))
                {
                    countBallsLabel.Text = (Convert.ToInt32(countBallsLabel.Text) + 1).ToString();
                    balls[i].Stop();
                }
            }
        }

        private void stopeBallButton_Click(object sender, EventArgs e)
        {
            stopeBallButton.Enabled = false;
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Stop();
                if (balls[i].OnForm())
                {
                    countBallsLabel.Text = (Convert.ToInt32(countBallsLabel.Text) + 1).ToString();
                }
            }

        }
        private void createSomeBallsButton_Click(object sender, EventArgs e)
        {
            countBallsLabel.Text = "0";
            balls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new MoveBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
