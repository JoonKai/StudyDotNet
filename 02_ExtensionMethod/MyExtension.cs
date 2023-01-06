using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ExtensionMethod
{
    /// <summary>
    /// 1.확장클래스는 스태틱 클래스 이어야 한다.
    /// 2.확장메서드는 스태틱 메서드 이어야 한다.
    /// 3.확장메서드의 매개변수는 반드시 this 라는 키워드를 붙인다.
    /// </summary>
    public static class MyExtension
    {
        //구조체 확장 메서드
        public static bool IsEven(this int a)
        {
            return a % 2 == 0;
        }
        //클래스 확장 메서드
        public static string DashAppend(this string s, string text)
        {
            return s + "-" + text;
        }
        //실드처리된 클래스는 파생클래스를 만들수 없기 때문에 확장 메서드를 만들어서 사용한다.
        public static int Modulo(this Calc calc, int a, int b)
        {
            return a % b;
        }
    }
}
