namespace KataBowlingMainProject
{
    public class Strike : Frame
    {
        public Strike()
        {
            this.FirstRoll = 10;
            this.SecondRoll = 0;
        }

        public override int GetScore(int nextRoll, int secondNextRoll)
        {
            var result = 10 + nextRoll + secondNextRoll;

            return result;
        }
    }
}