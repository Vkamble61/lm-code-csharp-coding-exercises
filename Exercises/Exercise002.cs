using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        // 👉 Remember to delete all unnecessary comments (like this one) when you're done! 

        public bool IsFromManchester(Person person )
        {
            return person != null && person.City == "Manchester";
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age >= ageLimit;
        }
    }
}
