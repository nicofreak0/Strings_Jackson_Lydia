namespace Strings_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks the user to input a character and assigns input to variable
            Console.WriteLine("Please input a character!");
            char myChar = Console.ReadKey() .KeyChar;

            // checks if the character user entered is a letter
            bool isLetter = Char.IsLetter(myChar);

            // prints results to console
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

            // asks the user a question and saves response to a variable, sentence
            Console.WriteLine("Why do you like video games?");
            string sentence = Console.ReadLine();

            // checks if the word is in the sentence
            Console.WriteLine("Enter a word.");
            string word = Console.ReadLine();

            //checks if the word is in the sentence
            bool isIn = sentence.Contains(word);

            // prints if the word is in the sentence
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");

        }
    }
}