﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string TestName { get; set; }
        public string Color { get; set; }
        public string ParentId { get; set; }
        public bool HasSubQuestion { get; set; }
    }
}
