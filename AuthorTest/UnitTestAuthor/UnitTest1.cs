using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAuthor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TextParser()
        {
            string input = "This is a statement, and so is this.";
            string expectedOutput = "this:2\nis:2\na:1\nstatement:1\nand:1\nso:1";//We are seprating the word and no.of count by colon(:) and for nextLine by (\n).
            string actual = ParserLibrary.clsParserLibrary.WordsCount(input);
            Assert.AreEqual(expectedOutput, actual);
        }
        [TestMethod]
        // Passing value is blank space and expected same but our function returning only blank without space
        public void TextParserWithBlank()
        {
            string input = "  ";
            string expectedOutput = "  ";
            string actual = ParserLibrary.clsParserLibrary.WordsCount(input);
            Assert.AreEqual(expectedOutput, actual);
        }

        [TestMethod]
        public void TextParserWithSpecialChars()
        {
            string input = "Thi.s is a s.tatement, and so is this.";
            string expectedOutput = "thi:1\ns:2\nis:2\na:1\ntatement:1\nand:1\nso:1\nthis:1";//We are seprating the word and no.of count by colon(:) and for nextLine by (\n).
            string actual = ParserLibrary.clsParserLibrary.WordsCount(input);
            Assert.AreEqual(expectedOutput, actual);
        }
    }
}
