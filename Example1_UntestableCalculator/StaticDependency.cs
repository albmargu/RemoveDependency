﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public static class StaticDependency
    {
        public static string GetDBName()
        { 
            return "MyDatabase.db"; 
        }
    }
}
