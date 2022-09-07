using System;

namespace OopCatExercise
{
	public abstract class Cat : ICat

	{
        //public const int AVERAGE_HEIGHT = 0;
        public int AverageHeight { get; set; }
        public bool IsAsleep { get; set; }
        public string Setting { get; set; }
        public Cat()
        {
            //AverageHeight = AVERAGE_HEIGHT;
            IsAsleep = false;
        }
        public abstract string Eat();
        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }

    }
}
