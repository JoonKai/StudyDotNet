using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExtensionMethod//확장 메서드 연습
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 124;
            //bool b = MyUtility.IsEven(a);// 확장메서드가 없었을때 이방식을 많이 사용했다.
            bool b = a.IsEven();
            //IsEven을 살펴보면 매개변수가 없다.
            b = 100.IsEven();
            //확장메서드의 첫번째 파라미터는 그 메서드를 호출한 객체를 의미한다.


            string s = "ABC";
            string s2 = s.DashAppend("DEF");

            Calc c = new Calc();
            int res = c.Modulo(5, 3);

            //interface 확장 메서드
            var list = new List<string> { "Alex", "Pane", "Jane", "Alexa" };
            var aNames = list.Where(p => p.StartsWith("A"));
        }

        
    }
}
