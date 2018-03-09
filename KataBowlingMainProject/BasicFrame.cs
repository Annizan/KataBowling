namespace KataBowlingMainProject
{
    public class BasicFrame : Frame
    {
        #region FrameConstruction

        public BasicFrame(int firsRoll, int secondRoll)
        {
            this.FirstRoll = firsRoll;
            this.SecondRoll = secondRoll;
        }

        

        #endregion

        public override int GetScore(int nextRoll, int secondNextRoll)
        {
            var result = FirstRoll + SecondRoll;
            return result;
        }
    }
}