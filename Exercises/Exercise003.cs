using System;
namespace Exercises
{
    public class Exercise003
    {
        class IceCreamFlavoursList
        {
            public string[] expected = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
            public string[] Expected { get { return expected; } }
            public IceCreamFlavoursList() { }
            public int IceCreamCode(string iceCreamFlavour)
            {
                try
                {
                    int index = 0;

                    for (int i = 0; i < expected.Length; i++)
                    {
                        if (iceCreamFlavour == expected[i])
                            index = i;
                    }
                    return index;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return -1;
                }
            }
        }
        public string[] IceCreamFlavours => new IceCreamFlavoursList().Expected;

        public int IceCreamCode(string iceCreamFlavour)
        {
            return new IceCreamFlavoursList().IceCreamCode(iceCreamFlavour);
        }
    }
}




