using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Bucket
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Bucket Next { get; set; }

        public Bucket () { }

        /// <summary>
        /// This custome constructor allows key and value to be set upon instantiation
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Bucket(string key, object value)
        {
            Key = key;
            Value = value;
            Next = new Bucket();
        }
    }
}
