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
            string word = "speakers";

            bool isUnique = Program.AreAllCharactersUnique(word);

            Assert.False(isUnique);
        }

        [Fact]
        public void CanReturnFalseWhenInputStringIsEmpty()
        {
            string word = "";

            bool isUnique = Program.AreAllCharactersUnique(word);

            Assert.False(isUnique);
        }
    }
}
