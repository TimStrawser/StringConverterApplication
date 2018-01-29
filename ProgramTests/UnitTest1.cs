
using StringConverter;
using System;
using Xunit;


namespace StringConverterTests
{
    public class UnitTests
    {
        [Fact]
        public void ConvertLettersToNumbersTest()
        {

            string userInput_a = "1";
            string userInput_z = "26";
            string userInputCaps_A = "2";
            string userInputCaps_Z = "52";
            string invalidUserInput = "-1";


            var convert = new String_Converter();

            convert.ConvertLettersToNumbers("a");
            Assert.Equal(userInput_a, convert.NumeralString);

            convert.ConvertLettersToNumbers("z");
            Assert.Equal(userInput_z, convert.NumeralString);


            convert.ConvertLettersToNumbers("A");
            Assert.Equal(userInputCaps_A,convert.NumeralString);

            convert.ConvertLettersToNumbers("Z");
            Assert.Equal(userInputCaps_Z, convert.NumeralString);

            convert.ConvertLettersToNumbers("5");
            Assert.Equal(invalidUserInput, convert.NumeralString);

        }
    }
}
