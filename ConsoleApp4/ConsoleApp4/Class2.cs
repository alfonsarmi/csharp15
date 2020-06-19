using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Class2 
    {
        
        private void MethodGeniar()
        {
            Class1 invokacior = new Class1();

            invokacior.Caca1();
            invokacior.Caca2();
            invokacior.testc = 1;
            invokacior.Caca1("a");
        }
    }
}
