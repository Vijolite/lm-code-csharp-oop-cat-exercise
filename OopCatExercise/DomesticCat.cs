using System;

namespace OopCatExercise
{
	public class DomesticCat : Cat
	{
        private const int AVERAGE_HEIGHT = 23;
        public DomesticCat() : base ()
        {
            Setting = "domestic";
            AverageHeight = AVERAGE_HEIGHT;
        }

        public override string Eat()
        {
            return "Purrrrrrr";
        }

    }
}
