namespace KataBowlingTests
{
    public class Spare : Frame
    {
        public Spare(string frameInString) : base(frameInString)
        {
            SetRolls();
        }

        protected override void SetRolls()
        {
            firstRoll = int.Parse(frameInString[0].ToString());
            secondRoll = 10 - firstRoll;
        }
        
    }
}