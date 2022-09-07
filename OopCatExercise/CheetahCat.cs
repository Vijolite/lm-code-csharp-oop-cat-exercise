using System;

namespace OopCatExercise
{
	public class CheetahCat : Cat
	{
        private const int AVERAGE_HEIGHT = 1100;
        public CheetahCat() : base ()
        {
            Setting = "wild";
            AverageHeight = AVERAGE_HEIGHT;
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }

    }
}
