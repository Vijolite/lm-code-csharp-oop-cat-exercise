using System;

namespace OopCatExercise
{
	public class SpecialDomesticCat : DomesticCat
	{
        public SpecialDomesticCat() : base ()
        {
        }

        public override string Eat()
        {
            Random rnd = new Random();
            int x = rnd.Next(2);
            return (x==0)?"Purrrrrrr":"It will do I suppose";
        }

    }
}
