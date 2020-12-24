﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency // changed Id and Value everywhere, made them auto implemented.
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }


        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
