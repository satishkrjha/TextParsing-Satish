using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLibrary
{
    public class clsParserLibrary
    {
        public static string WordsCount(string txtValue)
        {
            string txtOutput = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(txtValue) || string.IsNullOrWhiteSpace(txtValue))
                {
                    //txtOutput = "INPUT value in blank or null";
                    txtOutput = string.Empty;
                }
                else
                {
                    //Convert string into array and removing extra spaces and special chars
                    string[] breakToStr = ConvertToValidString(txtValue).ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    var stringCounts = breakToStr.GroupBy(x => x).Select(x => new { Name = x.Key, Count = x.Count() }).ToList();

                    foreach (var v in stringCounts)
                    {
                        if (string.IsNullOrEmpty(txtOutput))
                        {
                            txtOutput = v.Name + ":" + v.Count;//Seprating by colon(:)
                        }
                        else
                        {
                            txtOutput += "\n" + v.Name + ":" + v.Count;//Seprating by \n for new line 
                        }
                    }

                }

            }
            catch { throw; }
            return txtOutput;

        }

        //Function for replacing special characters with blank space
        private static string ConvertToValidString(string str)
        {
            var characters = str.Select(c =>
            {
                if (!char.IsLetter(c)) return ' ';
                return c;
            }).ToArray();

            return new string(characters);
        }

    }
}
