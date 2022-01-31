using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWindowsFormsApp
{
    public class PointAndSizeRandomBall:RandomPointBall
    {
        public PointAndSizeRandomBall(MainForm form):base(form)
        {
            size = random.Next(10, 80);
        }
    }
}
