using System;
using System.Collections;
using System.Collections.Generic;

namespace Codeally
{
    class Program
    {

        
        static int Main()
        {
            
            int a = 1;
            int b = 1;

            string value = Console.ReadLine();

            CharEnumerator charEnumerator = value.GetEnumerator();

                while (charEnumerator.MoveNext())
                {
                if (charEnumerator.Current == 'w') a++;
                else if (charEnumerator.Current == 's') a--;
                else if (charEnumerator.Current == 'a') b--;
                else if (charEnumerator.Current == 'd') b++;
                }

            int movesToPoint = (7 - a) + (7 - b);
            Console.WriteLine(movesToPoint);
            return movesToPoint;

        }
    }
}
