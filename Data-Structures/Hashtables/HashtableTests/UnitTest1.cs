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

            Assert.True(hashtable.Contains(key));
        }

        // Retrieving based on a key returns the value stored
        [Fact]
        public void CanRetrieveValueFromHashtable()
        {
            string key = "static";
            int value = 35;

            Hashtable hashtable = new Hashtable(10);

            hashtable.Add(key, value);

            Assert.Equal(value, Convert.ToInt32(hashtable.Get(key)));
        }

        // Successfully returns null for a key that does not exist in hashtable
        [Fact]
        public void CanReturnNullIfNoKey()
        {
            string key = "static";

            Hashtable hashtable = new Hashtable(10);

            Assert.Null(hashtable.Get(key));
        }

        // Successfully handles a collision within the hashtable
        //[Fact]
        //public void CanHandleCollision()
        //{
        //    string key = "static";
        //    int value1 = 35;
        //    int value2 = 55;

        //    Hashtable hashtable = new Hashtable(10);

        //    hashtable.Add(key, value1);
        //    hashtable.Add(key, value2);

        //    Assert.Equal(value1, Convert.ToInt32(hashtable.Get(key)));
        //}

        // Successfully retrieve a value from a bucket within the hashtable that has a collision

        // Successfully hash a key to an in-range value
    }
}
