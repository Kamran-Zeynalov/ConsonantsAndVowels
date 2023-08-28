namespace VowelsAndConsonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "KamrManAEMM";
            string allVowels = "AEIOUaeiou";
            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (allVowels.Contains(word[i])) vowels++;
                else if (char.IsLetter(word[i]) && !allVowels.Contains(word[i])) consonants++;
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants :" + consonants);


        }
    }
}