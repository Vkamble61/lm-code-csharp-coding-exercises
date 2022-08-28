using System;
using System.Collections.Generic;

using static System.Net.Mime.MediaTypeNames;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            string flag = "";

            if (input != null && input.ToString() != "")
            {
                string alphabets = "abcdefghijklmnopqrstuvwxyz";
                input = input.ToLower().ToString();

                foreach (char ch in alphabets.ToCharArray())
                {
                    if (!input.ToString().Contains(ch))
                        flag = "Missing";
                }

                if (flag == "Missing") return false;
                else return true;
            }
            else
                return false;
        }
    }
}
