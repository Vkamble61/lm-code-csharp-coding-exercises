using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return word;
            else
                return word[0].ToString().ToUpper() + word[1..word.Length];
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0].ToString() + "." + lastName[0].ToString();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return (double)Convert.ToDecimal(string.Format("{0:0.00}", originalPrice + (originalPrice * (vatRate / (double)100))));
        }

        public string Reverse(string sentence)
        {
            if (sentence != null)
            {
                string sentence1;
                char[] array1 = sentence.ToCharArray();
                Array.Reverse(array1);               
                sentence1 = new string(array1);
                return sentence1;
            }else
                return sentence;
        }

        public int CountLinuxUsers(List<User> users)
        {
            int linuxCnt = 0;

            if (users != null)
            {
                users.ForEach(userOSType => { if (userOSType.Type == "Linux") linuxCnt++; });
            }
            return linuxCnt;
        }
    }
}
