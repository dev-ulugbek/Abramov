using System.Runtime.CompilerServices;

namespace Abramow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Даны два действительных числа a и b. Получить их сумму,
            //разность и произведение.
            yte a, b;
            Console.Write("A: ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToByte(Console.ReadLine());

            int sum = a + b;
            int sum1 = a - b;
            int sum2 = a * b;
            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);


            //  2.Даны действительные числа x и y.Получить
            /* byte x, y;
            Console.Write("X: ");
            x = Convert.ToByte(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToByte(Console.ReadLine());
            int res = Math.Abs(x)-Math.Abs(y)/1+Math.Abs(x*y);
            Console.WriteLine(res);*/



            //  3.Дана длина ребра куба.Найти объем куба и площадь его
            //    боковой поверхности.
            /* byte l;
            Console.Write("L: ");
            l = Convert.ToByte(Console.ReadLine());
            int v = l*l*l;
            int s = 6 * l * l;
            Console.WriteLine("Oбъем " + v);
            Console.WriteLine("Площадь " + s);*/



            //  4.Даны два действительных положительных числа. Найти
            //    среднее арифметическое и среднее геометрическое этих чисел.
            /*byte a, b;
            Console.Write("A: ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToByte(Console.ReadLine());
            double c = (a + b) / 2;
            double d = Math.Sqrt(a*b);
            Console.WriteLine(c); */



            //  5.Даны два действительных числа.Найти среднее
            //    арифметическое этих чисел и среднее геометрическое их модулей.
            /* byte a, b;
            Console.Write("A:  ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("B:  ");
            b = Convert.ToByte(Console.ReadLine());
            int c = (a+b)/2;
            double d = Math.Sqrt(Math.Abs(a*b));
            Console.WriteLine(c);
            Console.WriteLine(d);*/



            //  14.Определить силу притяжения F между телами массы m 1 и
            //    m2, находящимися на расстоянии r друг от друга.
            /*double m1, m2, r, F, G=6.674;
            Console.Write("M:  ");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("M2:  ");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("R2:  ");
            r = Convert.ToDouble(Console.ReadLine());
            F = (G * m1 * m2) / Math.Pow(r, 2);
            Console.WriteLine("Result: " + F);*/




            //  15.Даны гипотенуза и катет прямоугольного треугольника.
            //       Найти второй катет и радиус вписанной окружности.

            /*double a, b, c, r;
            Console.Write("A:  ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("C:  ");
            c = Convert.ToDouble(Console.ReadLine());

            // c^2 = a^2 + b^2;
            
            b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            r = (a + b - c) / 2;
            Console.WriteLine("Result: " + b);
            Console.WriteLine("Radius:  " + r);*/



            //  16.Известна длина окружности. Найти площадь круга,
            //    ограниченного этой окружностью.
            //    S = (L^2) / (4π)
            /*double L, S, P = 3.14;
            Console.Write("L:  ");
            L = Convert.ToInt16(Console.ReadLine());
            S = (L * L) / ( 4 * P);
            Console.WriteLine("Result = " + S);*/




            //29.Даны действительные числа х, у.Не пользуясь никакими
            //    операциями, кроме умножения, сложения и вычитания, вычислить
            //      3x ^ 2y ^ 2 - 2xy ^ 2 - 7x ^ y - 4y ^ 2 + 15xy + 2x ^ 2 - 3x + 10y + 6
            //      Разрешается использовать не более восьми умножений и восьми
            //      сложений и вычитаний.
            //int x, y;
            //Console.Write("X: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Y: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //double res = 3 * Math.Pow(x, 2) * Math.Pow(y, 2) - 2 * x * Math.Pow(y, 2) -
            //    7 * Math.Pow(x, 2) * y - 4 * Math.Pow(x, 2) + 15 * x * y + 2 * Math.Pow(x, 2) - 3 * x + 10 * y + 6;
            //Console.WriteLine("Result:  " + res);

            /*double x, y, a, b, c, d, e, f, g, h;
            Console.Write("X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            a = x * y;
            b = Math.Pow(x, 2);
            c = Math.Pow(y, 2);
            d = Math.Pow(a, 2);
            e = b * c;
            f = 3 * d;
            g = 2 * e;
            h = 2 * b;
            double result = f - g - 7 * a - 4 * c + 15 * x * y + h - 3 * x + 10 * y + 6;
            Console.WriteLine("Result = " + result);*/


            //  30.Дано действительное число х.Не пользуясь никакими
            //  другими арифметическими операциями, кроме умножения, сложения и
            //  вычитания, вычислить
            //  1 − 2x + 3x^2 − 4x^3 и 1 + 2x + 3x^2 + 4x^3.
            //  Разрешается использовать не более восьми операций.
            /*int x;
            Console.Write("X:  ");
            x = Convert.ToInt32(Console.ReadLine());
            double res = 1 - 2 * x + 3 * (Math.Pow(x, 2)) - 4 * (Math.Pow(x, 3));
            double ans = 1 + 2 * x + 3 * (Math.Pow(x, 2)) + 4 * (Math.Pow(x, 3));
            Console.WriteLine(res);
            Console.WriteLine(ans);*/
            //double x;
            //Console.Write("X:  ");
            //x = Convert.ToDouble(Console.ReadLine());
            //double a = (Math.Pow(x, 2));
            //double b = (Math.Pow(x, 3));
            //double c = 3 * a;   
            //double d = 4 * b;
            //double result = 1 - 2 * x + c - d;
            //double _result = 1 + 2 * x + c + d;
            //Console.WriteLine(result);  
            //Console.WriteLine(_result);





            //32. Дано действительное число а. Не пользуясь никакими
            //другими арифметическими операциями, кроме умножения, получить:
            //а) a ^ 3  и a ^10  за четыре операции;
            //б) a ^ 4 и a^ 20 за пять операций;
            //в) a ^ 5  и a^13 за пять операций;
            //г) a ^ 5 и a^19 за пять операций;
            //д) a ^ 2 , a ^ 5, a ^ 17 за шесть операций;
            //е) a ^ 4 , a ^ 12, a ^ 28 за шесть операций.

            //double a;
            //Console.Write("A: ");
            //a = Convert.ToDouble(Console.ReadLine());






        }
    }
}