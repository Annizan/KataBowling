namespace KataBowlingMainProject
{
    public class Spare : Frame
    {
        public Spare(int firstRoll) 
        {
            this.FirstRoll  = firstRoll; 
            SecondRoll = 10 - firstRoll;
        }

        public override int GetScore(int nextRoll, int secondNextRoll)
        {
            var result = 10 + nextRoll;
            return result;
        }
    }
}