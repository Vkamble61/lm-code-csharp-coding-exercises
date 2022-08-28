using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
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
