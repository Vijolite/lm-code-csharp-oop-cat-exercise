using System;

namespace OopCatExercise
{
	public class LionCat : Cat
	{
        private const int AVERAGE_HEIGHT = 1100;
        public LionCat () : base ()
        {
            Setting = "wild";
            AverageHeight = AVERAGE_HEIGHT;
        }

        public override string Eat()
        {
            return "Roar!!!!";
        }

    }
}
