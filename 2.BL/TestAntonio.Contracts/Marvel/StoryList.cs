﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestAntonio.Contracts.Marvel
{
    public class StoryList
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<StorySummary> items { get; set; }
        public int returned { get; set; }
    }
}
