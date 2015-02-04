using System;
using System.Collections.Generic;
using System.IO;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> alphaEquiv = new Dictionary<String, String>();
            List<String> alphabet = new List<String> {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" 
            };
            Random random = new Random();

            foreach (string letter in alphabet.ToArray())
            {
                string value = alphabet[random.Next(alphabet.Count - 1)];

                alphabet.Remove(value);
                alphaEquiv.Add(letter, value);
            }

            int index = 0;
            string[] equivs = new string[alphaEquiv.Count];
            foreach (string key in alphaEquiv.Keys)
            {
                equivs[index] = key + " = " + alphaEquiv[key];
                index++;
            }

            System.IO.File.WriteAllLines("/alphabet.txt", 
                equivs);
        }
    }
}
