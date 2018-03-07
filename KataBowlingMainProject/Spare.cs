namespace KataBowlingMainProject
{
    public class Spare : Frame
    {
        public Spare(int firstRoll) 
        {
            this.firstRoll  = firstRoll; 
            secondRoll = 10 - firstRoll;
        }
    }
}