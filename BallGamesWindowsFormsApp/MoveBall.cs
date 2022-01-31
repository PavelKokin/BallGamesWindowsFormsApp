using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public class MoveBall:RandomPointBall
    {
        private Timer timer;
        public MoveBall(MainForm form): base(form)
        {
            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            var speedAbs = random.Next(2, 5);
            vx = speedAbs * GetSignSpeed();
            vy = speedAbs * GetSignSpeed();
        }
        private int GetSignSpeed()
        {
            double randomSignIndex = random.NextDouble();
            var sign = 1;
            if (randomSignIndex < 0.5)
            {
                sign = -1;
            }
            return sign;
        }
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public bool OnForm ()
        {
            return (x > 0 && x < form.ClientSize.Width - size && y > 0 && y < form.ClientSize.Height - size);
        }

        public bool Exists(int userPointX, int userPointY)
        {
            var x0 = x + size / 2;
            var y0 = y + size / 2;
            var dx = userPointX - x0;
            var dy = userPointY - y0;
            var radius = size / 2;
            return ((dx * dx + dy * dy) <= (radius * radius));
        }
        public bool IsMoved()
        {
            return timer.Enabled;
        }
    }
}
