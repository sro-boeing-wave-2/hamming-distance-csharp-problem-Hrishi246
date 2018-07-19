using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;

            if (original == null)
            {
                throw new ArgumentNullException("original");
            }
            if (current == null)
            {
                throw new ArgumentNullException("current");
            }

            if (original.Length != current.Length)
            {
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            }

            char[] set1 = original.ToCharArray();
            char[] set2 = current.ToCharArray();

            for (int i = 0; i < set1.Length; i++)
            {
                if (set1[i] != set2[i])
                {
                    hammingDistance++;
                }
            }


            return hammingDistance;
        }
    }
}

