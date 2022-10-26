using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //atama operatörü
            int a = 7, b = 12; 
            
            //İşlemli atama operatörleri
            a += 1;
            Console.WriteLine(a);
            a -= 2;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 3;
            Console.WriteLine(a);

            //İlişkisel Operatörler
            bool mantik = false;
            bool isSuccess = true, isUnsuccess = false;

            mantik = a == b;
            Console.WriteLine(mantik);
            mantik = a < b;
            Console.WriteLine(mantik);
            mantik = a > b;
            Console.WriteLine(mantik);
            mantik = a <= b;
            Console.WriteLine(mantik);
            mantik = a >= b;
            Console.WriteLine(mantik);

            //Aritmetik
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a % b);
            a = --a;
            Console.WriteLine(a);
            b = ++b;
            Console.WriteLine(b);

            //Mantıksal Operatörler
            if (a==12||b==12)
            {
                Console.WriteLine(isSuccess);
            }
            else
            {
                Console.WriteLine(isUnsuccess);
            }

            if (a == 12 && b == 12)
            {
                Console.WriteLine(isSuccess);
            }
            else
            {
                Console.WriteLine(isUnsuccess);
            }

            if (isSuccess && !isUnsuccess)
            {
                Console.WriteLine(isSuccess);
            }
            else
            {
                Console.WriteLine(isUnsuccess);
            }

        }
    }
}
