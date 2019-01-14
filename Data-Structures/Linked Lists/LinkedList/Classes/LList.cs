﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LList(Node node)
        {
            Head = node;
            Current = Head;
        }
    }
}
