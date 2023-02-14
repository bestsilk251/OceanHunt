using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OceanHunt
{
    public class Predator : Prey
    {
        private const int _defaultTimeToFeed = 6;
        public int TimeToFeed { get; set; }
        public Predator(Coordinate offSet, string image) : base(offSet, image)
        {
            TimeToFeed= _defaultTimeToFeed;
        }
        public override void Process()
        {
            if (TimeToFeed==0)
            {
                Die();
                return;
            }
            base.Process();
            TimeToFeed--;
        }
        public void Eat()
        {
            TimeToFeed = _defaultTimeToFeed;
        }
    }
}