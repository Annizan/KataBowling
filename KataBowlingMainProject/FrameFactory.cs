namespace KataBowlingMainProject
{
    public static class FrameFactory
    {
        public static Frame Create(string frameInString)
        {
            var isStrike = !int.TryParse(frameInString[0].ToString(), out int firstRoll);
            if (isStrike)
                return new Strike();
            var isSpare = !int.TryParse(frameInString[1].ToString(), out int secondRoll);
            if(isSpare)
                return new Spare(firstRoll);
            return new BasicFrame(firstRoll, secondRoll);
        }
    }
}