namespace StringProcessorApp
{
    public class Program
    {
        //reverse a given string without respecting the order
        //of the words in a sentence (without leveraging any out-of-the-box C# methods).

        //same as previous, but with respect to the order of the words.

        //remove a given set of forbidden characters from a given string.

        //calculate how many times each character is used in a given string.
        static void Main(string[] args)
        {
            var characterRemover = new CharacterRemover();
            var sanitString = characterRemover.GetSanitizedString("afterdark impression", "a,d,c,e,f".Split(","));
        }
    }
}
