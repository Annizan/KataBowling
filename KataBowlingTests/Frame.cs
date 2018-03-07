using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBowlingTests
{
    public abstract class Frame
    {
        protected int firstRoll;
        protected int secondRoll;
        protected string frameInString;

        protected Frame(string frameInString)
        {
            this.frameInString = frameInString;
        }


        public int GetBowlingPinFallen()
        {
            var bowlingPinFallen = firstRoll + secondRoll;
            return bowlingPinFallen;
        }
        protected abstract void SetRolls();

    }
}
