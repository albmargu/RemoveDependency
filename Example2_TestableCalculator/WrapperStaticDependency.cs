﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class WrapperStaticDependency : IWrapperStaticDependency
    {
        public string GetDBName() => StaticDependency.GetDBName();
    }
}
