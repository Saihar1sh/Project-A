using System;
using UnityEngine;

namespace se
{
[AttributeUsage(AttributeTargets.Class |
     AttributeTargets.Field |
   AttributeTargets.Method
    , AllowMultiple = true)]
    public class DebugAttribute : System.Attribute
    {
        public string Statement { get; private set; }

        public DebugAttribute(string statement)
        {
            this.Statement = statement;
            Console.WriteLine(statement);
        }
    }

}