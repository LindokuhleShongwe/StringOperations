using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringOperations
{
    public class Text
    {
        private string UserText { get; set; }// propeerty for userText

        public Text(String _UserText)//Constructor which sets the text from the user
        {
            UserText = _UserText;
        }
        public string VowelCount()//Method to count the vowels available in a string
        {
            int count = 0;

            foreach (var ch in UserText.ToCharArray())
            {
                string vowels = "aeiou";
                if (vowels.Contains(ch.ToString().ToLower()))
                    count++;
            }

            return count > 0 ? $"\nThe number of vowels is {count}" : "\nNo vowels were found";

        }
        public string CheckVowels()//Method to check if the string entered by the user has more or less vowels compared to non vowels
        {
            int count = 0;
            int Length = UserText.Length;

            foreach (var ch in UserText.ToCharArray())
            {
                string vowels = "aeiou";
                if (vowels.Contains(ch.ToString().ToLower()))
                    count++;
            }

            if (count < (Length - count))
            {
                //More none vowels
                return "The text has more non vowels than vowels";
            }
            else if (count > (Length - count))
            {
                //More vowels
                return "The text has more vowels than non vowels";
            }
            else
                //Equal
                return "The text has an equal amount of vowels and non vowels ";


        }
        public List<char> CheckDuplicates()//Method to check if the string has duplicate letters or not, the method uses hash to do that.
        {

            List<char> list = new List<char>();

            HashSet<char> hash = new HashSet<char>(UserText);
            HashSet<char> hashDup = new HashSet<char>();
            foreach (var c in UserText)
                if (hash.Contains(c))
                    hash.Remove(c);
                else
                    hashDup.Add(c);
            foreach (var x in hashDup)
                list.Add(x);

            return list;

        }
    }
}
