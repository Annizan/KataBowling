namespace KataBowlingTests
{
    public class BasicFrame : Frame
    {
        #region FrameConstruction

        public BasicFrame(string frameInString) : base(frameInString)
        {
            SetRolls();
        }

        protected override void SetRolls()
        {
            firstRoll = int.Parse(frameInString[0].ToString());
            secondRoll = int.Parse(frameInString[1].ToString());
        }

        #endregion
    }
}