using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExtensionMethod
{
    /// <summary>
    /// 1. 실드클래스 이기 때문에 파생클래스를 만들수 없다.
    /// </summary>
    public sealed class Calc
    {
        public int Add(int a, int b) { return a + b; }
        public int Substract(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
    }
}
