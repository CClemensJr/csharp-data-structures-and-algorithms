using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        public List<object> hashTable { get; set; }

        /// <summary>
        /// This method hashes the key then adds the key and the value to the table, handling collisions as needed.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, Object value)
        {

        }


        /// <summary>
        /// This method takes the key then returns the value from the table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The value associated with the key</returns>
        public Object Get(string key)
        {
            return null;
        }

        /// <summary>
        /// This method takes a key and returns a boolean, indicating if the key exists in the table already.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>True or false</returns>
        public bool Contains(string key)
        {
            return false;
        }

        /// <summary>
        /// This method takes in a key and returns an index in the collection
        /// </summary>
        /// <param name="key"></param>
        /// <returns>An integer index in the collection</returns>
        public int Hash(string key)
        {

            return 0;
        }
    }
}
