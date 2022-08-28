using System;
using System.Collections.Generic;
using Exercises.Models;
using System.Linq;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return string.IsNullOrWhiteSpace(word) ? word : word[0].ToString().ToUpper() + word[1..word.Length];
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0].ToString() + "." + lastName[0].ToString();
        }

        public double CalculateVat(double originalPrice, double vatRate)
        {
            return (double)Convert.ToDecimal(string.Format("{0:0.00}", originalPrice + (originalPrice * (vatRate / (double)100))));
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
                throw new ArgumentException(message: "Price cannot be negative. Please enter a valid price.");
            else if (vatRate < 0)
                throw new ArgumentException(message: "VAT cannot be negative. Please enter a valid VAT.");
            else
                return CalculateVat(originalPrice, vatRate);
        }

        public string Reverse(string sentence)
        {
            string reverseSentence = "";
            if (sentence != null)
            {
                char[] array1 = sentence.ToCharArray();
                Array.Reverse(array1);
                reverseSentence = new string(array1);
            }
            return sentence == null ? sentence : reverseSentence;
        }

        public int CountLinuxUsers(List<User> users)
        {
            return users == null ? 0 : users.Count(u1 => u1.Type == "Linux");
        }
    }
}
