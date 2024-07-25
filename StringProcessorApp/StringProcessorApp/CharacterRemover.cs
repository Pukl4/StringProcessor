using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessorApp
{
    public class CharacterRemover                
    {
        public static string GetString( string row, string user_input_char)
        {
            string[] splitRow = user_input_char.Split(',');

            for (int i = 0; i < splitRow.Length; i++)
            {
                    while (row.Contains(splitRow[i])) 
                    {
                        var ind = row.IndexOf(splitRow[i]);
                        var removed_row = row.Remove(ind, 1);
                        row = removed_row;
                    }
            }
            Console.WriteLine(row);
            return row;
        }
        
    }
}
