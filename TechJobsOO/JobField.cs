﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string value): this()
        {
            Value = Value;
        }


        public override string ToString()
        {
            return Value;
        }
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}