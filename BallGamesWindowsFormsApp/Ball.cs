using System.Drawing;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {
        protected int x = 100;
        protected int y = 100;
        protected int size = 40;
        protected MainForm form;
        protected int vx = 1;
        protected int vy = 1;
        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aquamarine;
            var rectangle = new Rectangle(x , y , size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = new SolidBrush(form.BackColor);
            var rectangle = new Rectangle(x , y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
    }
}
