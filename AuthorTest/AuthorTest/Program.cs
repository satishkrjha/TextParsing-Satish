using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "This is a statement, and so is this.";
            input = Console.ReadLine();//If you want to enter the input via screen then uncomment this line
            string output = ParserLibrary.clsParserLibrary.WordsCount(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
