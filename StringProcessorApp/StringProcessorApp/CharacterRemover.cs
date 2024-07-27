using System;
using System.Linq;

namespace StringProcessorApp
{
    public class CharacterRemover                
    {
        public string GetSanitizedString(string row, string[] forbiddenChars)
        { 
            var sanitizedString = string.Empty;

            foreach(var character in row)
            {
                if (!forbiddenChars.Contains(character.ToString()))
                {
                    sanitizedString += character;
                }
            }
            Console.WriteLine(sanitizedString);
            return sanitizedString;
        }
    }
}
