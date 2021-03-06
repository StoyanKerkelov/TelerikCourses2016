﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefiningClassesPart2
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
     AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttributes : System.Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttributes(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}