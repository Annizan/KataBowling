namespace KataBowlingMainProject
{
    public abstract class Frame
    {
        protected string frameInString;

        public int FirstRoll { get; protected set; }
        public int SecondRoll { get; protected set; }

        public int GetBowlingPinFallen()
        {
            var bowlingPinFallen = FirstRoll + SecondRoll;
            return bowlingPinFallen;
        }

        public abstract int GetScore(int nextRoll, int secondNextRoll);
    }
}
