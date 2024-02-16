using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    //This is the class under test
    public class Calculator
    {
        private readonly int _x, _y;

        #region Dependencies
        private IOperator _dependency1 = new Operator();
        private readonly Dependency _dependency2 = new();
        // StaticDependency is the third dependency
        #endregion

        public string Result { get; set; } = string.Empty;

        public Calculator(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Method1()
        {
            return _dependency1.Add(_x, _y);
        }

        public int Method2()
        {
            return _dependency2.Times(_x, _y);
        }

        public string Method3()
        {
            return StaticDependency.GetDBName();
        }
    }
}
