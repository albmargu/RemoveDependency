using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    //This is the class under test
    public class Calculator
    {
        private readonly int _x, _y;

        #region Dependencies
        private readonly IOperator _dependency1;
        private readonly Dependency _dependency2;
        private readonly IWrapperStaticDependency _dependency3;
        #endregion

        public string Result { get; set; } = string.Empty;

        public Calculator(int x, int y, IOperator dependency1, Dependency dependency2, IWrapperStaticDependency dependency3 = null)
        {
            _x = x;
            _y = y;
            _dependency1 = dependency1;
            _dependency2 = dependency2;
            _dependency3 = dependency3 ?? new WrapperStaticDependency();
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
            return _dependency3.GetDBName();
        }
    }
}
