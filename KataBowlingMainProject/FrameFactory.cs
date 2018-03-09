namespace KataBowlingMainProject
{
    public static class FrameFactory
    {
        public static Frame Create(string frameInString)
        {
            var isStrike = !int.TryParse(frameInString[0].ToString(), out int firstRoll);
            if (isStrike)
                return new Strike();
            bool isSpare = false;
            int secondRoll = 0;
            if (frameInString.Length >= 2)
                isSpare = !int.TryParse(frameInString[1].ToString(), out secondRoll);
            if (isSpare)
                return new Spare(firstRoll);
            return new BasicFrame(firstRoll, secondRoll);
        }
    }
}