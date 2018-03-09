using System.Collections.Generic;

namespace KataBowlingMainProject
{
    public class ScoreManager
    {
        private Stack<Frame> frames;
        private int nextRoll;
        private int secondNextRoll;

        public int Calculate(string framesString)
        {
            framesString = ScoreTranslator.Format(framesString);

            frames = new Stack<Frame>();
            foreach (var frame in framesString.Split(' '))
            {
                frames.Push(FrameFactory.Create(frame));
            }

            var result = CalculateScore(frames);


            return result;
        }

        private int CalculateScore(Stack<Frame> frames)
        {
            int result = 0;
            while (frames.Count != 0)
            {
                var frame = frames.Pop();
                if(frames.Count < 10)
                    result += frame.GetScore(nextRoll, secondNextRoll);
                SetNextRolls(frame);
            }

            return result;
        }

        private void SetNextRolls(Frame frame)
        {
            secondNextRoll = frame.FirstRoll == 10 ? nextRoll : frame.SecondRoll;
            nextRoll = frame.FirstRoll;
        }
    }
}