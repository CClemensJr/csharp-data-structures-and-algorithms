using System;
using Xunit;
using Hashtables.Classes;

namespace HashtableTests
{
    public class UnitTest1
    {
        // Adding a key/value to your hashtable results in the value being stored in the data structure
        [Fact]
        public void CanAddToHashtable()
        {
            string key = "static";
            int value = 35;

            Hashtable hashtable = new Hashtable(10);

            hashtable.Add(key, value);

            int hashedKey = hashtable.Hash(key);

            Assert.True(Convert.ToInt32(hashtable.Table[hashedKey]) == value);
        }

        // Retrieving based on a key returns the value stored

        // Successfully returns null for a key that does not exist in hashtable

        // Successfully handles a collision within the hashtable

        // Successfully retrieve a value from a bucket within the hashtable that has a collision

        // Successfully hash a key to an in-range value
    }
}
