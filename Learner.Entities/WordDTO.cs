﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner.Entities
{
    public class WordDTO
    {
        public string Word { get; set; }

        public HashSet<string> Traslates { get; set; }
    }
}