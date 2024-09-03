using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6;

public class B { }

public class A : B { }


public static class ParaPensar
{
    public static void Correr()
    {
        //A clase1 = new B();
        B clase2 = new A();
    }
}
