namespace KataBowlingTests
{
    public class Strike : Frame
    {
        public Strike(string frameInString) : base(frameInString)
        {
            SetRolls();
        }

        protected override void SetRolls()
        {
            firstRoll = 10;
            secondRoll = 0;
        }
    }
}