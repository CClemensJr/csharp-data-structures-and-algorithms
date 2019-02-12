using System;
using Xunit;
using AreCharactersUnique;

namespace AreCharactersUniqueTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnTrueWhenInputHasUniqueCharacters()
        {
            string word = "speak";

            bool isUnique = Program.AreAllCharactersUnique(word);

            Assert.True(isUnique);
        }

        [Fact]
        public void CanReturnFalseWhenInputDoesNotHaveUniqueCharacters()
        {

        }

        [Fact]
        public void CanReturnFalseWhenInputDoesNotAnyCharacters()
        {

        }
    }
}
