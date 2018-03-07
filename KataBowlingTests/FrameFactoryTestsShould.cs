using KataBowlingMainProject;
using NFluent;
using NUnit.Framework;

namespace KataBowlingTests
{
    public class FrameFactoryTestsShould
    {
        [Test]
        public void Create_a_Basic_Frame_When_Not_All_Pins_Are_Fallen()
        {
            Frame frame = FrameFactory.Create("26");
            Check.That(frame).IsInstanceOf<BasicFrame>();
        }

        [Test]
        public void Create_a_Spare_When_All_Pins_Fallen_After_Two_Rolls()
        {
            Frame frame = FrameFactory.Create("2/");
            Check.That(frame).IsInstanceOf<Spare>();
        }

        [Test]
        public void Create_A_Strike_When_All_Pins_Down_After_One_Roll()
        {
            Frame frame = FrameFactory.Create("X");
            Check.That(frame).IsInstanceOf<Strike>();
        }
    }
}
