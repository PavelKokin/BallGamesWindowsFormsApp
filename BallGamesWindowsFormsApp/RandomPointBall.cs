using System;
using System.Drawing;

namespace BallGamesWindowsFormsApp
{
    public class RandomPointBall:Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(MainForm form):base (form)
        {
            x = random.Next(form.ClientSize.Width);
            y = random.Next(form.ClientSize.Height);
        }
    }
}
