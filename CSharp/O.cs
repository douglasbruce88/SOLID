
namespace CSharp
{
    public abstract class ClosedForModification
    {
        public bool CanRollAgain (int firstDieScore, int secondDieScore)
        {
            return CanRollAgainImpl (firstDieScore, secondDieScore);
        }

        public abstract bool CanRollAgainImpl (int firstDieScore, int secondDieScore);
    }

    public class ThreeDoubles : ClosedForModification
    {
        readonly bool LastTwoRollsAreDoubles;
        public ThreeDoubles (bool lastTwoRollsAreDoubles)
        {
            this.LastTwoRollsAreDoubles = lastTwoRollsAreDoubles;
        }

        public override bool CanRollAgainImpl (int firstDieScore, int secondDieScore)
        {
            return !LastTwoRollsAreDoubles && (firstDieScore == secondDieScore);
        }
    }
}

