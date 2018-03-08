namespace KataBowlingMainProject
{
    public class BasicFrame : Frame
    {
        #region FrameConstruction

        public BasicFrame(int firsRoll, int secondRoll)
        {
            this.firstRoll = firsRoll;
            this.secondRoll = secondRoll;
        }

        

        #endregion

        public override int GetScore(int nextRoll, int secondNextRoll)
        {
            var result = firstRoll + secondRoll;
            return result;
        }
    }
}