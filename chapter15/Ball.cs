using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter15
{
    class Ball
    {
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
            if(ballInPlay != null)
            {
                ballInPlay(this, e);
            }
        }
    }

    class BallEventArgs: EventArgs
    {
        public int Trajectory { get; set; }
        public BallEventArgs(int trajectory)
        {
            this.Trajectory = trajectory;
        }
    }
}
