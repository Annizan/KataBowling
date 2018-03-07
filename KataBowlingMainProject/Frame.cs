namespace KataBowlingMainProject
{
    public abstract class Frame
    {
        protected int firstRoll;
        protected int secondRoll;
        protected string frameInString;

        public int GetBowlingPinFallen()
        {
            var bowlingPinFallen = firstRoll + secondRoll;
            return bowlingPinFallen;
        }
    }
}
