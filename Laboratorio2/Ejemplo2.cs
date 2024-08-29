using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Ejemplo2
    {
        public static void Main()
        {
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
        public class MyClass
        {
            public static int Valor;
        }
    }
}
