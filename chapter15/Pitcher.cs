using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter15
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Trajectory < 60)
                {
                    CatchBall();

                }
                else
                    CoverFirstBase();
            }
        }

        private void CoverFirstBase()
        {
            throw new NotImplementedException();
        }

        private void CatchBall()
        {
            throw new NotImplementedException();
        }
    }
}
