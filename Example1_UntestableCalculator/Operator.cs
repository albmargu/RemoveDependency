using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Operator : IOperator
    {
        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }
    }
}
